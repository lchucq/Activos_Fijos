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
    public partial class addAct : Form
    {
        string connString = File.ReadAllText(Application.StartupPath + "\\conn.dat");
        public addAct()
        {
            InitializeComponent();
        }

        private void addAct_Load(object sender, EventArgs e)
        {
            dtpFecCom.Text = DateTime.Now.ToShortDateString();
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
            command.CommandText = "SELECT * FROM parametrodepreciacion order by idPar";
            datos = new MySqlDataAdapter(command);
            DataTable dtRol = new DataTable();
            datos.Fill(dtRol);
            if (dtRol.Rows.Count > 0)
            {
                cbDepre.ValueMember = "idPar";
                cbDepre.DisplayMember = "desPar";
                cbDepre.DataSource = dtRol;
            }

            command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM tipoaquisicion order by idAdq";
            datos = new MySqlDataAdapter(command);
            DataTable dtAdq = new DataTable();
            datos.Fill(dtAdq);
            if (dtAdq.Rows.Count > 0)
            {
                cbAdqui.ValueMember = "idAdq";
                cbAdqui.DisplayMember = "nomAdq";
                cbAdqui.DataSource = dtAdq;
            }
            command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM categoria order by idCat";
            datos = new MySqlDataAdapter(command);
            DataTable dtCat = new DataTable();
            datos.Fill(dtCat);
            if (dtCat.Rows.Count > 0)
            {
                cbCat.ValueMember = "idCat";
                cbCat.DisplayMember = "desCat";
                cbCat.DataSource = dtCat;
            }

            conn.Close();
        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {
            //decimal cost;
            //if (decimal.TryParse(txtCost.Text, out cost))
            //    txtCost.Text = cost.ToString("N2");
            //else
            //    txtCost.Text = cost.ToString("N2");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNom.Text))
                    MessageBox.Show("Valor Inválido" + Environment.NewLine + "Descripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (string.IsNullOrWhiteSpace(txtNumCom.Text))
                    MessageBox.Show("Valor Inválido" + Environment.NewLine + "Comprobante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MySqlConnection conn = new MySqlConnection(connString);
                    conn.Open();

                    MySqlCommand command = conn.CreateCommand();
                    command.CommandText = "INSERT INTO activo (feccom, numcom, desact, valcom, depMen, valRes, created, tipoAquisicion_idAdq, "
                        +"usuario_idUsu, parametroDepreciacion_idPar, oficina_idOfi, categoria_idCat, estadoActivo_idEst) " +
                        "VALUES (@fec, @comp, @desc, @valcom, @depmen, @valres, now(), @idadq, @idusu, @idpar, @idofi, @idcat, 1)";
                    command.Parameters.Add("@fec", MySqlDbType.Date).Value = Convert.ToDateTime(dtpFecCom.Text);
                    command.Parameters.Add("@comp", MySqlDbType.String).Value = txtNumCom.Text.Trim();
                    command.Parameters.Add("@desc", MySqlDbType.String).Value = txtNom.Text.Trim();
                    command.Parameters.Add("@valcom", MySqlDbType.Decimal).Value = Convert.ToDecimal(txtCost.Text);
                    command.Parameters.Add("@depmen", MySqlDbType.Decimal).Value = Convert.ToDecimal(txtDepMes.Text);
                    command.Parameters.Add("@valres", MySqlDbType.Decimal).Value = Convert.ToDecimal(txtValRes.Text);
                    command.Parameters.Add("@idadq", MySqlDbType.Int32).Value = Convert.ToInt32(cbAdqui.SelectedValue);
                    command.Parameters.Add("@idusu", MySqlDbType.String).Value = Globals.codUsu;
                    command.Parameters.Add("@idpar", MySqlDbType.Int32).Value = Convert.ToInt32(cbDepre.SelectedValue);
                    command.Parameters.Add("@idofi", MySqlDbType.Int32).Value = Convert.ToInt32(cbOfi.SelectedValue);
                    command.Parameters.Add("@idcat", MySqlDbType.Int32).Value = Convert.ToInt32(cbCat.SelectedValue);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Registro Ingresado Exitosamente", "Registro Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    conn.Close();
                    txtNom.Text = "";
                    txtCost.Text = "0.00";
                    txtNumCom.Text = "";
                    txtDepMes.Text = "0.00";
                    txtValRes.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCost_Leave(object sender, EventArgs e)
        {
            decimal cost;
            if (decimal.TryParse(txtCost.Text, out cost))
                txtCost.Text = cost.ToString("N2");
            else
                txtCost.Text = cost.ToString("N2");
            cbDepre_SelectedIndexChanged(cbDepre, new EventArgs());
        }

        private void txtDepMes_Leave(object sender, EventArgs e)
        {
            decimal cost;
            if (decimal.TryParse(txtDepMes.Text, out cost))
                txtDepMes.Text = cost.ToString("N2");
            else
                txtDepMes.Text = cost.ToString("N2");
        }

        private void txtValRes_Leave(object sender, EventArgs e)
        {
            decimal cost;
            if (decimal.TryParse(txtValRes.Text, out cost))
                txtValRes.Text = cost.ToString("N2");
            else
                txtValRes.Text = cost.ToString("N2");
        }

        private void cbDepre_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32 mesVid = Convert.ToInt32((cbDepre.SelectedItem as DataRowView)["mesVid"].ToString());
            decimal monto = 0;
            if (decimal.TryParse(txtCost.Text, out monto))
            {
                if (monto > 0)
                {
                    txtDepMes.Text = Convert.ToDecimal(monto / mesVid).ToString("N2");
                    return;
                }
            }
            else
                txtDepMes.Text = Convert.ToDecimal(monto).ToString("N2");
        }
    }
}
