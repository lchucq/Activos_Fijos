using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static activosFijos.Program;

namespace activosFijos
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        string connString = File.ReadAllText(Application.StartupPath + "\\conn.dat");
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsu.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                msgError.Text = "";
                string codUsu = txtUsu.Text.Trim();
                string pasUsu = txtPass.Text.Trim();

                Regex rgx = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[.,!#$@%&*~+=_-])[A-Za-z\d.,!#$@%&*~+=_-]{8,30}$");
                string resu = rgx.IsMatch(pasUsu) ? "OK" : "NO";
                if (resu == "OK")
                {
                    MySqlConnection conn = new MySqlConnection(connString);
                    conn.Open();
                    MySqlCommand command = conn.CreateCommand();
                    MySqlDataAdapter datos;
                    //command.CommandText = "SELECT idUsu, nomUsu, apellido, email, usuario FROM usuario, rol WHERE usuario= @usu AND AES_DECRYPT(password,'codActFij') = @pas";
                    command.CommandText = "SELECT * FROM usuario, rol WHERE usuario= @usu AND AES_DECRYPT(password,'codActFij') = @pas AND usuario.idRol = rol.idRol";
                    command.Parameters.Add("@usu", MySqlDbType.String).Value = codUsu;
                    command.Parameters.Add("@pas", MySqlDbType.String).Value = pasUsu;
                    datos = new MySqlDataAdapter(command);
                    DataTable dtUsu = new DataTable();
                    datos.Fill(dtUsu);
                    if (dtUsu.Rows.Count > 0)
                    {
                        Globals.Name = dtUsu.Rows[0]["nomUsu"] + " " + dtUsu.Rows[0]["apellido"];
                        Globals.email = dtUsu.Rows[0]["email"].ToString();
                        Globals.Usuario = dtUsu.Rows[0]["usuario"].ToString();
                        Globals.codUsu = dtUsu.Rows[0]["idUsu"].ToString();
                        Menu menus = new Menu();
                        menus.Show();
                        this.Hide();
                    }
                    else
                        msgError.Text = "Usuario o Contraseña Inválida";
                    conn.Close();
                }
                else
                    msgError.Text = "Caracter invalido en contraseña";
            }
            catch(Exception ex)
            {
                msgError.Text = ex.Message;
                return;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
