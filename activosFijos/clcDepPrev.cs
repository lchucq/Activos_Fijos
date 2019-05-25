using activosFijos.Code;
using activosFijos.Rpt;
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
    public partial class clcDepPrev : Form
    {
        static DataTable dtDepreciables;
        string connString = File.ReadAllText(Application.StartupPath + "\\conn.dat");
        public clcDepPrev()
        {
            InitializeComponent();
        }

        private void clcDepPrev_Load(object sender, EventArgs e)
        {
            mtdFill();
        }

        private void mtdFill()
        {
            string messtr = "";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            MySqlDataAdapter datos;
            command.CommandText = "SELECT * FROM historialdepreciacion order by desDep DESC LIMIT 1";
            datos = new MySqlDataAdapter(command);
            DataTable dtCat = new DataTable();
            datos.Fill(dtCat);
            if (dtCat.Rows.Count > 0)
            {
                string[] mesAnn = dtCat.Rows[0]["desDep"].ToString().Split('-');
                Int16 mes = Convert.ToInt16(mesAnn[1]);
                Int16 Ann = Convert.ToInt16(mesAnn[0]);
                if (mes == 12)
                {
                    mes = 1;
                    Ann++;
                }
                else
                    mes++;
                if (mes < 10)
                    messtr = "0" + mes.ToString();
                else
                    messtr = mes.ToString();
                //lblMesAnn.Text = DateTime.Now.ToString("yyyy-MM");
                lblMesAnn.Text = Ann.ToString() + "-" + messtr;
            }
            else
            {
                lblMesAnn.Text = DateTime.Now.ToString("yyyy-MM");
                messtr = DateTime.Now.Month.ToString();
            }
            command = conn.CreateCommand();
            command.CommandText = "SELECT idAct, activo.desAct, depMen, par.mesVid, parametrodepreciacion_idPar idPar, IFNULL(his.mntDep,0) monDepre, "
                + "IFNULL(his.mssDep,0) mesesDepre  FROM activo LEFT JOIN (SELECT SUM(rial.monDep)mntDep, SUM(rial.mesDep)mssDep, rial.activo_idAct "
                + "FROM historialdepreciacion rial, activo WHERE rial.activo_idAct=activo.idAct GROUP BY activo_idAct) AS his ON (activo.idAct=his.activo_idAct), "
                + "parametrodepreciacion par WHERE estadoactivo_idEst=1 AND activo.parametroDepreciacion_idPar=PAR.idPar "
                + "AND (par.iniMesCom=1 OR MONTH(activo.fecCom) < @mess) AND IFNULL(his.mssDep,0)<par.mesVid";
            command.Parameters.Add("@mess", MySqlDbType.Int16).Value = Convert.ToInt16(messtr);
            datos = new MySqlDataAdapter(command);
            dtDepreciables = new DataTable();
            datos.Fill(dtDepreciables);
            if (dtDepreciables.Rows.Count > 0)
            {
                decimal totdepre = 0;
                grdView.DataSource = dtDepreciables;
                foreach (DataRow dr in dtDepreciables.Rows)
                    totdepre += Convert.ToDecimal(dr["depMen"]);
                lblTotal.Text = totdepre.ToString("N2");
                btnSearch.Visible = true;
                btnSearch.Focus();
            }
            
            conn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string annMes = lblMesAnn.Text;
                if (string.IsNullOrWhiteSpace(annMes))
                {
                    MessageBox.Show("Valor Inválido" + Environment.NewLine + "No se Recibio Año y Mes de Depreciación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else if (dtDepreciables == null && dtDepreciables.Rows.Count == 0)
                {
                    MessageBox.Show("Error No Existen Datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    MySqlConnection conn = new MySqlConnection(connString);
                    conn.Open();
                    MySqlCommand command;
                    foreach (DataRow dr in dtDepreciables.Rows)
                    {
                        command = conn.CreateCommand();
                        command.CommandText = "INSERT INTO historialdepreciacion (numCom, fecDep, monDep, mesDep, desDep, activo_idAct, usuario_idUsu, created) "
                            + "VALUES (@numPar, NOW(), @monD, 1, @desD, @actD, @usu, now())";
                        command.Parameters.Add("@numPar", MySqlDbType.Int16).Value = Convert.ToInt16(dr["idPar"]);
                        command.Parameters.Add("@monD", MySqlDbType.Decimal).Value = Convert.ToDecimal(dr["depMen"]);
                        command.Parameters.Add("@desD", MySqlDbType.String).Value = annMes;
                        command.Parameters.Add("@actD", MySqlDbType.Int32).Value = Convert.ToInt32(dr["idAct"]);
                        command.Parameters.Add("@usu", MySqlDbType.String).Value = Globals.codUsu;
                        command.ExecuteNonQuery();
                    }

                    command = conn.CreateCommand();
                    command.CommandText = "UPDATE activo AS act, (SELECT SUM(monDep)tdep, activo_idAct idAc FROM historialdepreciacion " +
                        "GROUP BY activo_idAct) AS td SET act.depAcu = td.tdep, act.valAct = act.valCom - td.tdep, act.ultDep=NOW() WHERE act.idAct = td.idAc";
                    command.ExecuteNonQuery();

                    command = conn.CreateCommand();
                    command.CommandText = "UPDATE activo AS act, parametrodepreciacion par, (SELECT SUM(mesDep)tdep, activo_idAct idAc FROM historialdepreciacion " +
                        "GROUP BY activo_idAct) AS td SET act.estadoActivo_idEst = 2 WHERE act.idAct = td.idAc AND act.parametroDepreciacion_idPar=par.idPar "
                        + "AND td.tDep >= par.mesVid";
                    command.ExecuteNonQuery();

                    command = conn.CreateCommand();
                    command.CommandText = "SELECT activo.oficina_idOfi idOfi, ofi.nomOfi, categoria_idCat idCat, cat.desCat, idAct, activo.desAct, "
                        +"activo.valCom, activo.depAcu, activo.valAct depAct, estadoactivo_idEst idEst, est.nomEst, his. monDep, his.mesDep, his.desDep, "
                        +"his.fecDep, usu.idUsu, CONCAT(usu.nomUsu,' ', usu.apellido)nomUsu FROM activo, historialdepreciacion his, "
                        +"parametrodepreciacion par, categoria cat, oficina ofi, estadoactivo est, usuario usu WHERE estadoactivo_idEst=1 "
                        +"AND activo.parametroDepreciacion_idPar=PAR.idPar and activo.categoria_idCat=cat.idCat and activo.oficina_idOfi=ofi.idOfi "
                        +"and activo.estadoActivo_idEst=est.idEst and activo.idAct=his.activo_idAct AND his.usuario_idUsu=usu.idUsu "
                        +"AND his.desDep = @desDep";
                    command.Parameters.Add("@desDep", MySqlDbType.String).Value = annMes;
                    MySqlDataAdapter datos = new MySqlDataAdapter(command);
                    DataTable dtDepre = new DataTable();
                    datos.Fill(dtDepre);
                    conn.Close();
                    if (dtDepre.Rows.Count > 0)
                    {
                        libGen lgen = new libGen();
                        rptFrm rp = new rptFrm();
                        rp.nomRep = "prtDepre.rdlc"; //nombre del reporte a utilizar
                        rp.dtParam = new DataTable(); // coleccion de parametros que tiene el reporte
                        rp.dtParam.Columns.Add("nom");
                        rp.dtParam.Columns.Add("val");
                        rp.dtParam.Rows.Add("nomRep", "Reporte de Depreciaciones de: " + lgen.annMes(annMes));
                        rp.ds = "dsRep"; //nombre del dataset
                        rp.dtSet = dtDepre; //contenido del dataset
                        MessageBox.Show("Registro Ingresado Exitosamente", "Registro Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        btnSearch.Visible = false;
                        rp.Show(); //mostrar formulario de reporte
                        mtdFill();
                    }
                    else
                    {
                        MessageBox.Show("HA OCURRIDO UN ERROR" + Environment.NewLine + "AL REGISTRAR DEPRECIACIONES", "ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
            catch
            {
                this.Close();
            }


            //try
            //{

                //MySqlConnection conn = new MySqlConnection(connString);
                //conn.Open();
                //MySqlCommand command = conn.CreateCommand();
                //MySqlDataAdapter datos;
                //command.CommandText = "SELECT idAct, activo.desAct, depMen, oficina_idOfi idOfi, ofi.nomOfi, "
                //    +"parametrodepreciacion_idPar idPar, par.mesVid, categoria_idCat idCat, cat.desCat, estadoactivo_idEst idEst, "
                //    +"est.nomEst, his.idhis idUltDep, his.numCom comUltDep, his.fecDep fecUltDep, his.monDep monUltDep, his.mesDep mesUltDep, "
                //    +"his.desDep desUltDep  FROM activo LEFT JOIN (SELECT historialdepreciacion.* FROM historialdepreciacion, activo "
                //    +"WHERE historialdepreciacion.activo_idAct=activo.idAct ORDER BY created DESC LIMIT 1) AS his ON (activo.idAct=his.activo_idAct), "
                //    +"parametrodepreciacion par, categoria cat, oficina ofi, estadoactivo est WHERE estadoactivo_idEst=1 "
                //    +"AND activo.parametroDepreciacion_idPar=PAR.idPar and activo.categoria_idCat=cat.idCat and activo.oficina_idOfi=ofi.idOfi "
                //    +"and activo.estadoActivo_idEst=est.idEst AND oficina_idOfi LIKE @oficina AND categoria_idCat LIKE @categoria";
                //command.Parameters.Add("@oficina", MySqlDbType.String).Value = cbOfi.SelectedValue; ;
                //command.Parameters.Add("@categoria", MySqlDbType.String).Value = cbCat.SelectedValue;
                //datos = new MySqlDataAdapter(command);
                //DataTable dtPar = new DataTable();
                //datos.Fill(dtPar);
                //if (dtPar.Rows.Count > 0)
                //{
                //    grdView.DataSource = dtPar;
                //    btnCont.Visible = true;
                //}
                //conn.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error:" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
