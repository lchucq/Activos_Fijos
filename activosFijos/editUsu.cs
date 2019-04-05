using activosFijos.Code;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static activosFijos.Program;

namespace activosFijos
{
    public partial class editUsu : MetroFramework.Forms.MetroForm
    {
        public string codUsu;
        string connString = File.ReadAllText(Application.StartupPath + "\\conn.dat");
        public editUsu()
        {
            InitializeComponent();
        }

        private void editUsu_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            MySqlDataAdapter datos;
            command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM oficina order by idOfi";
            datos = new MySqlDataAdapter(command);
            DataTable dtOfi = new DataTable();
            datos.Fill(dtOfi);
            if (dtOfi.Rows.Count > 0)
            {
                cbOfi.ValueMember = "idOfi";
                cbOfi.DisplayMember = "nomOfi";
                cbOfi.DataSource = dtOfi;
            }

            command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM rol order by idRol";
            datos = new MySqlDataAdapter(command);
            DataTable dtRol = new DataTable();
            datos.Fill(dtRol);
            conn.Close();
            if (dtRol.Rows.Count > 0)
            {
                cbRol.ValueMember = "idRol";
                cbRol.DisplayMember = "nomRol";
                cbRol.DataSource = dtRol;
            }
            
            if (!string.IsNullOrWhiteSpace(codUsu))
            {
                conn.Open();
                command = conn.CreateCommand();
                command.CommandText = "SELECT * FROM usuario where idUsu = @idUsu";
                command.Parameters.Add("@idUsu", MySqlDbType.String).Value = codUsu;
                datos = new MySqlDataAdapter(command);
                DataTable dtUsu = new DataTable();
                datos.Fill(dtUsu);
                conn.Close();
                if (dtUsu.Rows.Count > 0)
                {
                    txtCodUsu.Text = dtUsu.Rows[0]["idUsu"].ToString();
                    txtNom.Text = dtUsu.Rows[0]["nomUsu"].ToString();
                    txtApe.Text = dtUsu.Rows[0]["apellido"].ToString();
                    txtEmail.Text = dtUsu.Rows[0]["email"].ToString();
                    txtDir.Text = dtUsu.Rows[0]["dirUsu"].ToString();
                    txtCel.Text = dtUsu.Rows[0]["celUsu"].ToString();
                    txtUsuario.Text = dtUsu.Rows[0]["usuario"].ToString();
                    cbRol.SelectedValue = dtUsu.Rows[0]["idRol"].ToString();
                    cbOfi.SelectedValue = dtUsu.Rows[0]["oficina_idOfi"].ToString();
                }
                else
                {
                    MessageBox.Show("Error:" + Environment.NewLine + "No Existe Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Hide();
                }
            }
        }

        private void btnRst_Click(object sender, EventArgs e)
        {
            try
            {
                string pass = genPas.contrasena();
                string usuario = txtUsuario.Text;
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command = conn.CreateCommand();
                command.CommandText = "UPDATE usuario SET password=AES_ENCRYPT(@password,'codActFij') where idUsu=@codUsu and usuario=@usuario";
                command.Parameters.Add("@usuario", MySqlDbType.String).Value = usuario;
                command.Parameters.Add("@password", MySqlDbType.String).Value = pass;
                command.Parameters.Add("@codUsu", MySqlDbType.Int32).Value = Convert.ToInt32(txtCodUsu.Text);
                command.ExecuteNonQuery();
                envMail send = new envMail();
                send.sendPass(1, txtEmail.Text.Trim(), pass, usuario, txtNom.Text.Trim() + " " + txtApe.Text.Trim());
                MessageBox.Show("Credenciales enviadas Exitosamente", "Registro Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                libGen libg = new libGen();
                if (string.IsNullOrWhiteSpace(txtNom.Text))
                    MessageBox.Show("Valor Inválido" + Environment.NewLine + "Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (string.IsNullOrWhiteSpace(txtNom.Text))
                    MessageBox.Show("Valor Inválido" + Environment.NewLine + "Apellidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (string.IsNullOrWhiteSpace(txtEmail.Text) || !libg.IsValidEmail(txtEmail.Text))
                    MessageBox.Show("Valor Inválido" + Environment.NewLine + "Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (string.IsNullOrWhiteSpace(txtCel.Text))
                    MessageBox.Show("Valor Inválido" + Environment.NewLine + "Celular", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MySqlConnection conn = new MySqlConnection(connString);
                    conn.Open();
                    MySqlCommand command = conn.CreateCommand();
                    command = conn.CreateCommand();
                    command.CommandText = "UPDATE usuario SET nomUsu=@nom, apellido=@ape, email=@email, dirUsu=@dir, celUsu=@cel," +
                        " idRol=@idRol, oficina_idOfi=@oficina where idUsu=@codUsu";
                        //"VALUES (, , , , , @usuario, AES_ENCRYPT(@password,'codActFij'), , )";
                    command.Parameters.Add("@nom", MySqlDbType.String).Value = txtNom.Text.Trim();
                    command.Parameters.Add("@ape", MySqlDbType.String).Value = txtApe.Text.Trim();
                    command.Parameters.Add("@dir", MySqlDbType.String).Value = txtDir.Text.Trim();
                    command.Parameters.Add("@email", MySqlDbType.String).Value = txtEmail.Text.Trim();
                    command.Parameters.Add("@cel", MySqlDbType.String).Value = txtCel.Text.Trim();
                    //command.Parameters.Add("@usuario", MySqlDbType.String).Value = codUsu;
                    //command.Parameters.Add("@password", MySqlDbType.String).Value = pass;
                    command.Parameters.Add("@idRol", MySqlDbType.Int32).Value = Convert.ToInt32(cbRol.SelectedValue);
                    command.Parameters.Add("@oficina", MySqlDbType.Int32).Value = Convert.ToInt32(cbOfi.SelectedValue);
                    command.Parameters.Add("@codUsu", MySqlDbType.Int32).Value = Convert.ToInt32(txtCodUsu.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Registro Modificado Exitosamente", "Registro Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    conn.Close();
                    txtNom.Text = "";
                    txtApe.Text = "";
                    txtDir.Text = "";
                    txtEmail.Text = "";
                    txtCel.Text = "";
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
