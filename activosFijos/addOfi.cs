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
    public partial class addOfi : Form
    {
        string connString = File.ReadAllText(Application.StartupPath + "\\conn.dat");
        public addOfi()
        {
            InitializeComponent();
        }

        private void mtdFill()
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
                grdOfi.DataSource = dtOfi;
            }
            conn.Close();
        }

        private void addOfi_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            MySqlDataAdapter datos;
            command.CommandText = "SELECT permisos.* FROM usuario, asignacionpermiso, permisos where usuario.idRol=asignacionpermiso.rol_idRol "
                + "AND asignacionpermiso.Permisos_idPer=permisos.idPer and permisos.codPer='ADDOFI' and usuario.idUsu=@codUsu";
            command.Parameters.Add("@codUsu", MySqlDbType.String).Value = Globals.codUsu;
            datos = new MySqlDataAdapter(command);
            DataTable dtRol = new DataTable();
            datos.Fill(dtRol);
            conn.Close();
            if (dtRol.Rows.Count == 0)
            {
                txtDes.Enabled = false;
                btnSave.Visible = false;
                txtNom.Enabled = false;
                MessageBox.Show("No tien Permiso para Ingreso de Nueva Oficina", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                command.CommandText = "INSERT INTO oficina (nomOfi, desOfi) VALUES (@nomOfi, @desOfi)";
                command.Parameters.Add("@nomOfi", MySqlDbType.String).Value = txtNom.Text;
                command.Parameters.Add("@desOfi", MySqlDbType.String).Value = txtDes.Text;
                command.ExecuteNonQuery();
                MessageBox.Show("Registro Ingresado Exitosamente", "Registro Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn.Close();
                mtdFill();
                txtNom.Text = "";
            }
            else
            {
                txtNom.Focus();
                MessageBox.Show("Valor Inválido" + Environment.NewLine + "Nombre de Oficina", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }
    }
}
