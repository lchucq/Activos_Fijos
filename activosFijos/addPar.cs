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
    public partial class addPar : Form
    {
        string connString = File.ReadAllText(Application.StartupPath + "\\conn.dat");
        public addPar()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNom.Text))
                    MessageBox.Show("Valor Inválido" + Environment.NewLine + "Nombre Parámetro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (nudMeses.Value<1)
                    MessageBox.Show("Valor Inválido" + Environment.NewLine + "Meses Vida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MySqlConnection conn = new MySqlConnection(connString);
                    conn.Open();

                    MySqlCommand command = conn.CreateCommand();
                    command.CommandText = "INSERT INTO parametrodepreciacion (desPar, mesVid, iniMesCom, usuario_idUsu, created) VALUES (@nom, @mes, @ini, @usu, now())";
                    command.Parameters.Add("@nom", MySqlDbType.String).Value = txtNom.Text.Trim();
                    command.Parameters.Add("@mes", MySqlDbType.Int24).Value = nudMeses.Value;
                    command.Parameters.Add("@ini", MySqlDbType.Bit).Value = cbIniMesCom.Checked ? true : false;
                    command.Parameters.Add("@usu", MySqlDbType.String).Value = Globals.codUsu;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Registro Ingresado Exitosamente", "Registro Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    conn.Close();
                    txtNom.Text = "";
                    nudMeses.Value = 0;
                    mtdFill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigo = grdView.Rows[e.RowIndex].Cells[0].Value.ToString();
            editPar editar = new editPar();
            editar.codPar = codigo;
            editar.Show();
            grdView.DataSource = null;
            txtNom.Text = "";
            
        }

        private void addPar_Load(object sender, EventArgs e)
        {
            mtdFill();
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlDataAdapter datos;
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT permisos.* FROM usuario, asignacionpermiso, permisos where usuario.idRol=asignacionpermiso.rol_idRol "
                + "AND asignacionpermiso.Permisos_idPer=permisos.idPer and permisos.codPer='PARDEP' and usuario.idUsu=@codUsu";
            command.Parameters.Add("@codUsu", MySqlDbType.String).Value = Globals.codUsu;
            datos = new MySqlDataAdapter(command);
            DataTable dtPer = new DataTable();
            datos.Fill(dtPer);
            conn.Close();
            if (dtPer.Rows.Count == 0)
            {
                btnSave.Visible = false;
                MessageBox.Show("No tien Permiso para Modificar Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void mtdFill()
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            MySqlDataAdapter datos;
            command.CommandText = "SELECT idPar, desPar, mesVid FROM parametrodepreciacion";
            datos = new MySqlDataAdapter(command);
            DataTable dtPar = new DataTable();
            datos.Fill(dtPar);
            if (dtPar.Rows.Count > 0)
                grdView.DataSource = dtPar;
            conn.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            mtdFill();
        }
    }
}
