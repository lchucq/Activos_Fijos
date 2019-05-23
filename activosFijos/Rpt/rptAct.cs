using activosFijos.Code;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace activosFijos.Rpt
{
    public partial class rptAct : Form
    {
        string connString = File.ReadAllText(Application.StartupPath + "\\conn.dat");
        public rptAct()
        {
            InitializeComponent();
        }

        private void rptAct_Load(object sender, EventArgs e)
        {
            DataTable dtDatos = libGen.consSql("SELECT idOfi valPar, nomOfi desPar FROM oficina order by idOfi", connString);
            if (dtDatos.Rows.Count > 0)
            {
                libGen.priLin(dtDatos);
                cbOfi.ValueMember = "valPar";
                cbOfi.DisplayMember = "desPar";
                cbOfi.DataSource = dtDatos;
            }
            dtDatos = libGen.consSql("SELECT idPar valPar, desPar FROM parametrodepreciacion order by idPar", connString);
            if (dtDatos.Rows.Count > 0)
            {
                libGen.priLin(dtDatos);
                cbPar.ValueMember = "valPar";
                cbPar.DisplayMember = "desPar";
                cbPar.DataSource = dtDatos;
            }
            dtDatos = libGen.consSql("SELECT idAdq valPar, nomAdq desPar FROM tipoaquisicion order by idAdq", connString);
            if (dtDatos.Rows.Count > 0)
            {
                libGen.priLin(dtDatos);
                cbAdq.ValueMember = "valPar";
                cbAdq.DisplayMember = "desPar";
                cbAdq.DataSource = dtDatos;
            }
            dtDatos = libGen.consSql("SELECT idCat valPar, desCat desPar FROM categoria order by idCat", connString);
            if (dtDatos.Rows.Count > 0)
            {
                libGen.priLin(dtDatos);
                cbCat.ValueMember = "valPar";
                cbCat.DisplayMember = "desPar";
                cbCat.DataSource = dtDatos;
            }
            dtDatos = libGen.consSql("SELECT idEst valPar, nomEst desPar FROM estadoActivo order by idEst", connString);
            if (dtDatos.Rows.Count > 0)
            {
                libGen.priLin(dtDatos);
                cbEst.ValueMember = "valPar";
                cbEst.DisplayMember = "desPar";
                cbEst.DataSource = dtDatos;
            }
            dpIni.Value = DateTime.Now;
            dpFin.Value = DateTime.Now;
            chbFechas_CheckedChanged(chbFechas, new EventArgs());
        }

        private void chbFechas_CheckedChanged(object sender, EventArgs e)
        {
            if (chbFechas.Checked)
            {
                dpIni.Enabled = true;
                dpFin.Enabled = true;
            }
            else
            {
                dpIni.Enabled = false;
                dpFin.Enabled = false;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            try
            {
                string tipOfi = cbOfi.SelectedValue.ToString() == "0" ? "%" : cbOfi.SelectedValue.ToString();
                string tipCat = cbCat.SelectedValue.ToString() == "0" ? "%" : cbCat.SelectedValue.ToString();
                string tipPar = cbPar.SelectedValue.ToString() == "0" ? "%" : cbPar.SelectedValue.ToString();
                string tipAdq = cbAdq.SelectedValue.ToString() == "0" ? "%" : cbAdq.SelectedValue.ToString();
                string tipEst = cbEst.SelectedValue.ToString() == "0" ? "%" : cbEst.SelectedValue.ToString();
                DateTime dtIni = dpIni.Value;
                DateTime dtFin = dpFin.Value;
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                MySqlDataAdapter datos;
                command = conn.CreateCommand();
                string commSql = "SELECT idAct, act.desAct, act.fecCom, act.numCom, act.ultDep,act.depMen, valcom, depacu, valact, "
                    + "valres, par.mesVid, his.mssDep mesDep, par.desPar, ofi.desOfi, cat.desCat, adq.nomAdq, est.nomEst FROM activo act "
                    + "LEFT JOIN (SELECT SUM(rial.mesDep)mssDep, rial.activo_idAct FROM historialdepreciacion rial, activo WHERE rial.activo_idAct=activo.idAct "
                    + "GROUP BY activo_idAct) AS his ON (act.idAct=his.activo_idAct), parametrodepreciacion par, oficina ofi, categoria cat, "
                    + "tipoaquisicion adq, estadoactivo est WHERE act.parametroDepreciacion_idPar=PAR.idPar AND act.oficina_idOfi=ofi.idOfi "
                    + "AND act.categoria_idCat=cat.idCat AND act.tipoAquisicion_idAdq=adq.idAdq AND act.estadoActivo_idEst=est.idEst "
                    + "AND par.idPar LIKE @tipPar AND ofi.idOfi LIKE @tipOfi AND cat.IdCat LIKE @tipCat AND adq.idAdq LIKE @tipAdq AND est.idEst LIKE @tipEst ";
                if (chbFechas.Checked)
                {
                    commSql += "AND act.fecCom >= @fecIni AND act.fecCom <= @fecFin ";
                    command.Parameters.Add("@fecIni", MySqlDbType.DateTime).Value = dtIni;
                    command.Parameters.Add("@fecFin", MySqlDbType.DateTime).Value = dtFin;
                }
                commSql += " ORDER BY ofi.idOfi, cat.idCat, act.idAct"; 
                command.CommandText = commSql;
                command.Parameters.Add("@tipPar", MySqlDbType.String).Value = tipPar;
                command.Parameters.Add("@tipOfi", MySqlDbType.String).Value = tipOfi;
                command.Parameters.Add("@tipCat", MySqlDbType.String).Value = tipCat;
                command.Parameters.Add("@tipAdq", MySqlDbType.String).Value = tipAdq;
                command.Parameters.Add("@tipEst", MySqlDbType.String).Value = tipEst;
                datos = new MySqlDataAdapter(command);
                DataTable dtAct = new DataTable();
                datos.Fill(dtAct);
                conn.Close();
                if (dtAct.Rows.Count > 0)
                {
                    libGen lgen = new libGen();
                    rptFrm rp = new rptFrm();
                    rp.nomRep = "rptActivos.rdlc"; //nombre del reporte a utilizar
                    rp.dtParam = new DataTable(); // coleccion de parametros que tiene el reporte
                    rp.dtParam.Columns.Add("nom");
                    rp.dtParam.Columns.Add("val");
                    rp.dtParam.Rows.Add("nomRep", "REPORTE DE ACTIVOS");
                    rp.dtParam.Rows.Add("tipPar", (cbPar.SelectedItem as DataRowView)["desPar"].ToString());
                    rp.dtParam.Rows.Add("tipOfi", (cbOfi.SelectedItem as DataRowView)["desPar"].ToString());
                    rp.dtParam.Rows.Add("tipCat", (cbCat.SelectedItem as DataRowView)["desPar"].ToString());
                    rp.dtParam.Rows.Add("tipAdq", (cbAdq.SelectedItem as DataRowView)["desPar"].ToString());
                    rp.dtParam.Rows.Add("tipEst", (cbEst.SelectedItem as DataRowView)["desPar"].ToString());
                    if (chbFechas.Checked)
                    {
                        rp.dtParam.Rows.Add("fecIni", dtIni.ToShortDateString());
                        rp.dtParam.Rows.Add("fecFin", dtFin.ToShortDateString());
                    }
                    else
                    {
                        rp.dtParam.Rows.Add("fecIni", "");
                        rp.dtParam.Rows.Add("fecFin", "");
                    }
                    rp.ds = "dsRep"; //nombre del dataset
                    rp.dtSet = dtAct; //contenido del dataset
                    rp.Show(); //mostrar formulario de reporte
                }
                else
                    MessageBox.Show("Error:" + Environment.NewLine + "No Existen Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}