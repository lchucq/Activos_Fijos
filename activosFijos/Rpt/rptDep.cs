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

namespace activosFijos.Rpt
{
    public partial class rptDep : Form
    {
        string connString = File.ReadAllText(Application.StartupPath + "\\conn.dat");
        public rptDep()
        {
            InitializeComponent();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            try
            {
                
                string tipMes = cbMes.SelectedValue.ToString() == "00" ? "%" : cbMes.SelectedValue.ToString();
                string tipAnn = nudAnn.Value.ToString();
                DateTime dtIni = dpIni.Value;
                DateTime dtFin = dpFin.Value;
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                MySqlDataAdapter datos;
                command = conn.CreateCommand();
                //SELECT act.idAct, act.desAct, ofi.nomOfi, cat.desCat, his.fecDep, his.monDep, his.mesDep, his.desDep, par.desPar FROM historialdepreciacion his, activo act, parametrodepreciacion par, oficina ofi, categoria cat WHERE his.activo_idAct=act.idAct AND his.numCom=par.idPar AND act.oficina_idOfi=ofi.idOfi AND act.categoria_idCat=cat.idCat ORDER BY his.fecDep

                string commSql = "SELECT act.idAct, act.desAct, ofi.nomOfi, cat.desCat, his.fecDep, his.monDep, his.mesDep, his.desDep, "
                    + "par.desPar FROM historialdepreciacion his, activo act, parametrodepreciacion par, oficina ofi, categoria cat "
                    + "WHERE his.activo_idAct=act.idAct AND his.numCom=par.idPar AND act.oficina_idOfi=ofi.idOfi AND act.categoria_idCat=cat.idCat "
                    +"AND his.desDep LIKE @desDep ";
                if (rb2.Checked)
                {
                    command.Parameters.Add("@desDep", MySqlDbType.String).Value = "1-%";
                    commSql += "AND his.fecDep >= @fecIni AND his.fecDep <= @fecFin ";
                    command.Parameters.Add("@fecIni", MySqlDbType.DateTime).Value = dtIni;
                    command.Parameters.Add("@fecFin", MySqlDbType.DateTime).Value = dtFin;
                }
                if(rb1.Checked)
                    command.Parameters.Add("@desDep", MySqlDbType.String).Value = tipAnn + "-" + tipMes;
                commSql += "ORDER BY his.fecDep";
                command.CommandText = commSql;
                datos = new MySqlDataAdapter(command);
                DataTable dtAct = new DataTable();
                datos.Fill(dtAct);
                conn.Close();
                if (dtAct.Rows.Count > 0)
                {
                    libGen lgen = new libGen();
                    rptFrm rp = new rptFrm();
                    rp.nomRep = "rptDepreciaciones.rdlc"; //nombre del reporte a utilizar
                    rp.dtParam = new DataTable(); // coleccion de parametros que tiene el reporte
                    rp.dtParam.Columns.Add("nom");
                    rp.dtParam.Columns.Add("val");
                    if (rb2.Checked)
                    {
                        rp.dtParam.Rows.Add("nomRep", "REPORTE DE SALIDAS DE ACTIVOS");
                        rp.dtParam.Rows.Add("fecIni", dtIni.ToShortDateString());
                        rp.dtParam.Rows.Add("fecFin", dtFin.ToShortDateString());
                        rp.dtParam.Rows.Add("tipMes", "");
                    }
                    else
                    {
                        rp.dtParam.Rows.Add("nomRep", "REPORTE DE DEPRECIACIONES POR MES");
                        libGen _libGen = new libGen();
                        rp.dtParam.Rows.Add("fecIni", "");
                        rp.dtParam.Rows.Add("fecFin", "");
                        rp.dtParam.Rows.Add("tipMes", _libGen.annMes(tipAnn + "-" + tipMes));
                    }
                    rp.ds = "dsRep"; //nombre del dataset
                    rp.dtSet = dtAct; //contenido del dataset
                    rp.Show(); //mostrar formulario de reporte
                }
                else
                    MessageBox.Show("Error:" + Environment.NewLine + "No Existen Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rptDep_Load(object sender, EventArgs e)
        {
            rb1.Checked = true;
            rb1_CheckedChanged(rb1, new EventArgs());
            DataTable dt = new DataTable();
            dt.Columns.Add("valPar");
            dt.Columns.Add("desPar");
            dt.Rows.Add("00", "Todos los Meses");
            dt.Rows.Add("01", "Enero");
            dt.Rows.Add("02", "Febrero");
            dt.Rows.Add("03", "Marzo");
            dt.Rows.Add("04", "Abril");
            dt.Rows.Add("05", "Mayo");
            dt.Rows.Add("06", "Junio");
            dt.Rows.Add("07", "Julio");
            dt.Rows.Add("08", "Agosto");
            dt.Rows.Add("09", "Septiembre");
            dt.Rows.Add("10", "Octubre");
            dt.Rows.Add("11", "Noviembre");
            dt.Rows.Add("12", "Diciembre");
            cbMes.DataSource = dt;
            cbMes.ValueMember = "valPar";
            cbMes.DisplayMember = "desPar";
            dpFin.Value = DateTime.Now;
            dpIni.Value = DateTime.Now;
            nudAnn.Value = DateTime.Now.Year;
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb1.Checked)
            {
                cbMes.Enabled = true;
                nudAnn.Enabled = true;
                dpIni.Enabled = false;
                dpFin.Enabled = false;
            }
            else
            {
                cbMes.Enabled = false;
                nudAnn.Enabled = false;
                dpIni.Enabled = true;
                dpFin.Enabled = true;
            }
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2.Checked)
            {
                dpIni.Enabled = true;
                dpFin.Enabled = true;
                cbMes.Enabled = false;
                nudAnn.Enabled = false;
            }
            else
            {
                dpIni.Enabled = false;
                dpFin.Enabled = false;
                cbMes.Enabled = true;
                nudAnn.Enabled = true;
            }
        }
    }
}
