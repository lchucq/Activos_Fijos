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
using static activosFijos.Menu;

namespace activosFijos
{
    public partial class addRol : Form
    {
        string connString = File.ReadAllText(Application.StartupPath + "\\conn.dat");
        public addRol()
        {
            InitializeComponent();
        }

        private void mtdFill()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            MySqlDataAdapter datos;
            command.CommandText = "SELECT * FROM rol order by idRol";
            datos = new MySqlDataAdapter(command);
            DataTable dtRol = new DataTable();
            datos.Fill(dtRol);
            if (dtRol.Rows.Count > 0)
            {
                grdRol.DataSource = dtRol;
            }
            conn.Close();
        }

        private void addRol_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            MySqlDataAdapter datos;
            command.CommandText = "SELECT permisos.* FROM usuario, asignacionpermiso, permisos where usuario.idRol=asignacionpermiso.rol_idRol "
                + "AND asignacionpermiso.Permisos_idPer=permisos.idPer and permisos.codPer='ROLUSU' and usuario.idUsu=@codUsu";
            command.Parameters.Add("@codUsu", MySqlDbType.String).Value = Globals.codUsu;
            datos = new MySqlDataAdapter(command);
            DataTable dtRol = new DataTable();
            datos.Fill(dtRol);
            conn.Close();
            if (dtRol.Rows.Count == 0)
            {
                label2.Visible = false;
                btnSave.Visible = false;
                txtNom.Visible = false;
                MessageBox.Show("No tien Permiso para Ingreso de Nuevo Rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mtdFill();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNom.Text))
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "INSERT INTO rol (nomRol) VALUES (@nomRol)";
                command.Parameters.Add("@nomRol", MySqlDbType.String).Value = txtNom.Text;
                command.ExecuteNonQuery();
                MessageBox.Show("Registro Ingresado Exitosamente", "Registro Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn.Close();
                mtdFill();
                txtNom.Text = "";
            }
            else
            {
                txtNom.Focus();
                MessageBox.Show("Valor Inválido" + Environment.NewLine + "Nombre de Rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
