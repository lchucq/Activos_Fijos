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
    public partial class addUsu : Form
    {
        string connString = File.ReadAllText(Application.StartupPath + "\\conn.dat");
        public addUsu()
        {
            InitializeComponent();
        }

        private void addUsu_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            MySqlDataAdapter datos;
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
            if (dtRol.Rows.Count > 0)
            {
                cbRol.ValueMember = "idRol";
                cbRol.DisplayMember = "nomRol";
                cbRol.DataSource = dtRol;
            }

            command = conn.CreateCommand();
            command.CommandText = "SELECT permisos.* FROM usuario, asignacionpermiso, permisos where usuario.idRol=asignacionpermiso.rol_idRol "
                + "AND asignacionpermiso.Permisos_idPer=permisos.idPer and permisos.codPer='INGUSU' and usuario.idUsu=@codUsu";
            command.Parameters.Add("@codUsu", MySqlDbType.String).Value = Globals.codUsu;
            datos = new MySqlDataAdapter(command);
            DataTable dtPer = new DataTable();
            datos.Fill(dtPer);
            conn.Close();
            if (dtPer.Rows.Count == 0)
            {
                btnSave.Visible = false;
                MessageBox.Show("No tien Permiso para Ingreso de Nuevo Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();

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
                    command.CommandText = "SELECT * FROM usuario";
                    MySqlDataAdapter datos = new MySqlDataAdapter(command);
                    DataTable dtUsu = new DataTable();
                    datos.Fill(dtUsu);
                    int contUsu = dtUsu.Rows.Count;
                    string codUsu = (contUsu + 1) + libg.genUsu(txtNom.Text.Trim() + " " + txtApe.Text.Trim());
                    string pass = genPas.contrasena();
                    command = conn.CreateCommand();
                    command.CommandText = "INSERT INTO usuario (nomUsu, apellido, email, dirUsu, celUsu, usuario, password, idRol, oficina_idOfi) "+
                        "VALUES (@nom, @ape, @email, @dir, @cel, @usuario, AES_ENCRYPT(@password,'codActFij'), @idRol, @oficina)";
                    command.Parameters.Add("@nom", MySqlDbType.String).Value = txtNom.Text.Trim();
                    command.Parameters.Add("@ape", MySqlDbType.String).Value = txtApe.Text.Trim();
                    command.Parameters.Add("@dir", MySqlDbType.String).Value = txtDir.Text.Trim();
                    command.Parameters.Add("@email", MySqlDbType.String).Value = txtEmail.Text.Trim();
                    command.Parameters.Add("@cel", MySqlDbType.String).Value = txtCel.Text.Trim();
                    command.Parameters.Add("@usuario", MySqlDbType.String).Value = codUsu;
                    command.Parameters.Add("@password", MySqlDbType.String).Value = pass;
                    command.Parameters.Add("@idRol", MySqlDbType.Int32).Value = Convert.ToInt32(cbRol.SelectedValue);
                    command.Parameters.Add("@oficina", MySqlDbType.Int32).Value = Convert.ToInt32(cbOfi.SelectedValue);
                    command.ExecuteNonQuery();
                    envMail send = new envMail();
                    send.sendPass(1, txtEmail.Text.Trim(), pass, codUsu, txtNom.Text.Trim() + " " + txtApe.Text.Trim());
                    MessageBox.Show("Registro Ingresado Exitosamente", "Registro Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    conn.Close();
                    txtNom.Text = "";
                    txtApe.Text = "";
                    txtDir.Text = "";
                    txtEmail.Text = "";
                    txtCel.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

