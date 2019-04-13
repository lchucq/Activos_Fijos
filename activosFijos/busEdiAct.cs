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
    public partial class busEdiAct : Form
    {
        string connString = File.ReadAllText(Application.StartupPath + "\\conn.dat");
        public busEdiAct()
        {
            InitializeComponent();
        }

        private void busEdiAct_Load(object sender, EventArgs e)
        {
            txtNom.Focus();
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            MySqlDataAdapter datos;
            command = conn.CreateCommand();
            command.CommandText = "SELECT permisos.* FROM usuario, asignacionpermiso, permisos where usuario.idRol=asignacionpermiso.rol_idRol "
                + "AND asignacionpermiso.Permisos_idPer=permisos.idPer and permisos.codPer='EDIACT' and usuario.idUsu=@codUsu";
            command.Parameters.Add("@codUsu", MySqlDbType.String).Value = Globals.codUsu;
            datos = new MySqlDataAdapter(command);
            DataTable dtPer = new DataTable();
            datos.Fill(dtPer);
            conn.Close();
            if (dtPer.Rows.Count == 0)
            {
                txtNom.Visible = false;
                btnSave.Visible = false;
                MessageBox.Show("No tien Permiso para Modificar Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtNom.Text))
                {
                    MySqlConnection conn = new MySqlConnection(connString);
                    conn.Open();
                    MySqlCommand command = conn.CreateCommand();
                    MySqlDataAdapter datos;
                    command.CommandText = "SELECT idAct, fecCom, desAct, valCom FROM activo where desAct LIKE '%" + txtNom.Text.Trim() + "%' order by idAct";
                    datos = new MySqlDataAdapter(command);
                    DataTable dtAct = new DataTable();
                    datos.Fill(dtAct);
                    if (dtAct.Rows.Count > 0)
                        grdView.DataSource = dtAct;
                    conn.Close();
                }
                else
                {
                    txtNom.Focus();
                    MessageBox.Show("Ingresar Valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigo = grdView.Rows[e.RowIndex].Cells[0].Value.ToString();
            editAct editar = new editAct();
            editar.codAct = codigo;
            editar.Show();
            grdView.DataSource = null;
            txtNom.Text = "";
            txtNom.Focus();
        }
    }
}
