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
    public partial class editAct : MetroFramework.Forms.MetroForm
    {
        public string codAct;
        string connString = File.ReadAllText(Application.StartupPath + "\\conn.dat");
        public editAct()
        {
            InitializeComponent();
        }

        private void editAct_Load(object sender, EventArgs e)
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

            command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM estadoActivo order by idEst";
            datos = new MySqlDataAdapter(command);
            DataTable dtEstadot = new DataTable();
            datos.Fill(dtEstadot);
            if (dtEstadot.Rows.Count > 0)
            {
                cbEstado.ValueMember = "idEst";
                cbEstado.DisplayMember = "nomEst";
                cbEstado.DataSource = dtEstadot;
            }

            //conn.Close();

            if (!string.IsNullOrWhiteSpace(codAct))
            {
                //conn.Open();
                command = conn.CreateCommand();
                command.CommandText = "SELECT * FROM activo where idAct = @idAct";
                command.Parameters.Add("@idAct", MySqlDbType.String).Value = codAct;
                datos = new MySqlDataAdapter(command);
                DataTable dtAct = new DataTable();
                datos.Fill(dtAct);
                conn.Close();
                if (dtAct.Rows.Count > 0)
                {
                    txtIdAct.Text = dtAct.Rows[0]["idAct"].ToString();
                    txtNom.Text = dtAct.Rows[0]["desAct"].ToString();
                    txtNumCom.Text = dtAct.Rows[0]["numCom"].ToString();
                    dtpFecCom.Text = Convert.ToDateTime(dtAct.Rows[0]["fecCom"]).ToShortDateString();
                    txtCost.Text = Convert.ToDecimal(dtAct.Rows[0]["valCom"]).ToString("N2");
                    txtValRes.Text = Convert.ToDecimal(dtAct.Rows[0]["valRes"]).ToString("N2");
                    cbAdqui.SelectedValue = dtAct.Rows[0]["tipoAquisicion_idAdq"].ToString();
                    cbDepre.SelectedValue = dtAct.Rows[0]["parametroDepreciacion_idPar"].ToString();
                    cbOfi.SelectedValue = dtAct.Rows[0]["oficina_idOfi"].ToString();
                    cbCat.SelectedValue = dtAct.Rows[0]["categoria_idCat"].ToString();
                    cbEstado.SelectedValue = dtAct.Rows[0]["estadoActivo_idEst"].ToString();
                }
                else
                {
                    MessageBox.Show("Error:" + Environment.NewLine + "No Existe Activo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Hide();
                }
            }
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
                    command.CommandText = "UPDATE activo SET feccom=@fec, numcom=@comp, desact=@desc, valcom=@valcom, depMen=@depmen," +
                        "valRes=@valres, tipoAquisicion_idAdq=@idadq, usuario_idUsu=@idusu, parametroDepreciacion_idPar=@idpar, oficina_idOfi=@idofi," +
                        "categoria_idCat=@idcat, estadoActivo_idEst=@estado where idAct=@idAct";
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
                    command.Parameters.Add("@estado", MySqlDbType.Int32).Value = Convert.ToInt32(cbEstado.SelectedValue);
                    command.Parameters.Add("@idAct", MySqlDbType.Int32).Value = Convert.ToInt32(txtIdAct.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Registro Actualizado Exitosamente", "Registro Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    conn.Close();
                    txtNom.Text = "";
                    txtCost.Text = "0.00";
                    txtNumCom.Text = "";
                    txtDepMes.Text = "0.00";
                    txtValRes.Text = "0.00";
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbDepre_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32 mesVid = Convert.ToInt32((cbDepre.SelectedItem as DataRowView)["mesVid"].ToString());
            decimal monto = 0;
            if (decimal.TryParse(txtCost.Text, out monto))
            {
                if (monto > 0)
                {
                    decimal depreciado=0;
                    Int16 meses=0;
                    MySqlConnection conn = new MySqlConnection(connString);
                    conn.Open();
                    MySqlCommand command = conn.CreateCommand();
                    MySqlDataAdapter datos;
                    command.CommandText = "SELECT sum(monDep)monDep, sum(mesDep)meses FROM historialdepreciacion where activo_idAct="
                        + txtIdAct.Text+" group by activo_idAct";
                    datos = new MySqlDataAdapter(command);
                    DataTable dtDepre = new DataTable();
                    datos.Fill(dtDepre);
                    if (dtDepre.Rows.Count > 0)
                    {
                        depreciado = Convert.ToDecimal(dtDepre.Rows[0]["monDep"]);
                        meses = Convert.ToInt16(dtDepre.Rows[0]["meses"]);
                    }
                    conn.Close();
                    txtDepMes.Text = Convert.ToDecimal((monto - depreciado) / (mesVid - meses)).ToString("N2");
                    return;
                }
            }
            else
                txtDepMes.Text = Convert.ToDecimal(monto).ToString("N2");
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
    }
}
