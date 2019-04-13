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

namespace activosFijos
{
    public partial class editPar : MetroFramework.Forms.MetroForm
    {
        public string codPar;
        string connString = File.ReadAllText(Application.StartupPath + "\\conn.dat");
        public editPar()
        {
            InitializeComponent();
        }

        private void editPar_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(codPar))
            {
                MySqlConnection conn = new MySqlConnection(connString);
                MySqlCommand command = conn.CreateCommand();
                MySqlDataAdapter datos;
                conn.Open();
                command = conn.CreateCommand();
                command.CommandText = "SELECT * FROM parametrodepreciacion where idPar = @idPar";
                command.Parameters.Add("@idPar", MySqlDbType.Int32).Value = Convert.ToInt32(codPar);
                datos = new MySqlDataAdapter(command);
                DataTable dtUsu = new DataTable();
                datos.Fill(dtUsu);
                conn.Close();
                if (dtUsu.Rows.Count > 0)
                {
                    txtCodUsu.Text = dtUsu.Rows[0]["idPar"].ToString();
                    txtNom.Text = dtUsu.Rows[0]["desPar"].ToString();
                    nudMeses.Text = dtUsu.Rows[0]["mesVid"].ToString();
                }
                else
                {
                    MessageBox.Show("Error:" + Environment.NewLine + "No Existe Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Hide();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNom.Text))
                    MessageBox.Show("Valor Inválido" + Environment.NewLine + "Nombre Parámetro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (nudMeses.Value < 1)
                    MessageBox.Show("Valor Inválido" + Environment.NewLine + "Meses Depreciación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MySqlConnection conn = new MySqlConnection(connString);
                    conn.Open();
                    MySqlCommand command = conn.CreateCommand();
                    command = conn.CreateCommand();
                    command.CommandText = "UPDATE parametrodepreciacion SET desPar=@nom, mesVid=@mes where idPar=@idPar";
                    command.Parameters.Add("@nom", MySqlDbType.String).Value = txtNom.Text.Trim();
                    command.Parameters.Add("@mes", MySqlDbType.Int32).Value = nudMeses.Value;
                    command.Parameters.Add("@idPar", MySqlDbType.Int32).Value = Convert.ToInt32(txtCodUsu.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Registro Modificado Exitosamente", "Registro Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    conn.Close();
                    txtNom.Text = "";
                    nudMeses.Text = "";
                    txtCodUsu.Text = "";
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
