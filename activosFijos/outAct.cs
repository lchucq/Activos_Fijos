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
    public partial class outAct : MetroFramework.Forms.MetroForm
    {
        public string codAct;
        string connString = File.ReadAllText(Application.StartupPath + "\\conn.dat");
        public outAct()
        {
            InitializeComponent();
        }

        private void outAct_Load(object sender, EventArgs e)
        {
            DataTable dtDatos = libGen.consSql("SELECT idOfi valPar, nomOfi desPar FROM oficina order by idOfi", connString);
            if (dtDatos.Rows.Count > 0)
            {
                cbOfi.ValueMember = "valPar";
                cbOfi.DisplayMember = "desPar";
                cbOfi.DataSource = dtDatos;
            }
            dtDatos = libGen.consSql("SELECT idPar valPar, desPar FROM parametrodepreciacion order by idPar", connString);
            if (dtDatos.Rows.Count > 0)
            {
                cbDepre.ValueMember = "valPar";
                cbDepre.DisplayMember = "desPar";
                cbDepre.DataSource = dtDatos;
            }
            dtDatos = libGen.consSql("SELECT idAdq valPar, nomAdq desPar FROM tipoaquisicion order by idAdq", connString);
            if (dtDatos.Rows.Count > 0)
            {
                cbAdqui.ValueMember = "valPar";
                cbAdqui.DisplayMember = "desPar";
                cbAdqui.DataSource = dtDatos;
            }
            dtDatos = libGen.consSql("SELECT idCat valPar, desCat desPar FROM categoria order by idCat", connString);
            if (dtDatos.Rows.Count > 0)
            {
                cbCat.ValueMember = "valPar";
                cbCat.DisplayMember = "desPar";
                cbCat.DataSource = dtDatos;
            }
            dtDatos = libGen.consSql("SELECT idEst valPar, nomEst desPar FROM estadoActivo order by idEst", connString);
            if (dtDatos.Rows.Count > 0)
            {
                cbEstado.ValueMember = "valPar";
                cbEstado.DisplayMember = "desPar";
                cbEstado.DataSource = dtDatos;
            }
            if (!string.IsNullOrWhiteSpace(codAct))
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                MySqlDataAdapter datos;
                command = conn.CreateCommand();
                command.CommandText = "SELECT act.*, par.mesVid, td.tDep FROM activo act, parametroDepreciacion par, "
                    + "(SELECT SUM(mesDep)tdep, activo_idAct idAc FROM historialdepreciacion GROUP BY activo_idAct) AS td "
                    + "WHERE act.idAct = td.idAc AND act.parametroDepreciacion_idPar=par.idPar AND estadoActivo_idEst != 3 AND idAct = @idAct";
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
                    txtValCom.Text = Convert.ToDecimal(dtAct.Rows[0]["valCom"]).ToString("N2");
                    txtDepAcu.Text = Convert.ToDecimal(dtAct.Rows[0]["depAcu"]).ToString("N2");
                    txtValAct.Text = Convert.ToDecimal(dtAct.Rows[0]["valAct"]).ToString("N2");
                    txtMesVid.Text = dtAct.Rows[0]["mesVid"].ToString();
                    txtMesDep.Text = dtAct.Rows[0]["tDep"].ToString();
                    txtMesRst.Text = (Convert.ToInt32(dtAct.Rows[0]["mesVid"]) - Convert.ToInt32(dtAct.Rows[0]["tDep"])).ToString();
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
                if (string.IsNullOrWhiteSpace(txtRazBaj.Text) || txtRazBaj.Text.Trim().Length < 2)
                    MessageBox.Show("Error:" + Environment.NewLine + "Debe ingresar razon de Baja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string desDep = "1-" + txtRazBaj.Text.Trim();
                    MySqlConnection conn = new MySqlConnection(connString);
                    conn.Open();
                    MySqlCommand command = conn.CreateCommand();
                    command.CommandText = "INSERT INTO historialdepreciacion (numCom, fecDep, monDep, mesDep, desDep, activo_idAct, usuario_idUsu, created) "
                        + "VALUES (@numPar, NOW(), @monD, @mesDep, @desD, @actD, @usu, now())";
                    command.Parameters.Add("@numPar", MySqlDbType.Int16).Value = Convert.ToInt16(cbDepre.SelectedValue);
                    command.Parameters.Add("@monD", MySqlDbType.Decimal).Value = Convert.ToDecimal(txtValAct.Text);
                    command.Parameters.Add("@mesDep", MySqlDbType.Int32).Value = Convert.ToInt32(txtMesRst.Text);
                    command.Parameters.Add("@desD", MySqlDbType.String).Value = desDep;
                    command.Parameters.Add("@actD", MySqlDbType.Int32).Value = Convert.ToInt32(txtIdAct.Text);
                    command.Parameters.Add("@usu", MySqlDbType.String).Value = Globals.codUsu;
                    command.ExecuteNonQuery();

                    command = conn.CreateCommand();
                    command.CommandText = "UPDATE activo AS act, (SELECT SUM(monDep)tdep, activo_idAct idAc FROM historialdepreciacion " +
                        "GROUP BY activo_idAct) AS td SET act.depAcu = td.tdep, act.valAct = act.valCom - td.tdep, act.ultDep=NOW(), "
                        + "estadoActivo_idEst=3, act.valRes=0 WHERE act.idAct = td.idAc AND act.idACt=@idAct";
                    command.Parameters.Add("@idAct", MySqlDbType.Int32).Value = Convert.ToInt32(txtIdAct.Text);
                    command.ExecuteNonQuery();

                    command = conn.CreateCommand();
                    command.CommandText = "SELECT act.idAct, act.fecCom, act.numCom, act.desAct, act.valCom, act.depAcu, act.valAct, "
                        + "act.valRes, cat.desCat, ofi.nomOfi, est.nomEst, par.desPar nomPar, his.fecDep, his.monDep, his.mesDep, his.desDep, "
                        + "usu.nomUsu FROM historialdepreciacion his, activo act, categoria cat, oficina ofi, estadoactivo est, "
                        + "parametrodepreciacion par, usuario usu WHERE his.activo_idAct=act.idAct AND act.categoria_idCat=cat.idCat "
                        + "AND act.oficina_idOfi=ofi.idOfi AND act.estadoActivo_idEst=est.idEst AND act.parametroDepreciacion_idPar=par.idPar "
                        + "AND his.usuario_idUsu=usu.idUsu AND his.desDep = @desDep AND his.activo_idAct=@idAct";
                    command.Parameters.Add("@desDep", MySqlDbType.String).Value = desDep;
                    command.Parameters.Add("@idAct", MySqlDbType.String).Value = Convert.ToInt32(txtIdAct.Text);
                    MySqlDataAdapter datos = new MySqlDataAdapter(command);
                    DataTable dtDepre = new DataTable();
                    datos.Fill(dtDepre);
                    conn.Close();
                    if (dtDepre.Rows.Count > 0)
                    {
                        libGen lgen = new libGen();
                        rptFrm rp = new rptFrm();
                        rp.nomRep = "rptSalida.rdlc"; //nombre del reporte a utilizar
                        rp.dtParam = new DataTable(); // coleccion de parametros que tiene el reporte
                        rp.dtParam.Columns.Add("nom");
                        rp.dtParam.Columns.Add("val");
                        rp.dtParam.Rows.Add("nomRep", "SALIDA DE ACTIVOS POR AJUSTE");
                        rp.ds = "dsRep"; //nombre del dataset
                        rp.dtSet = dtDepre; //contenido del dataset
                        MessageBox.Show("Registro Ingresado Exitosamente", "Registro Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Hide();
                        rp.Show(); //mostrar formulario de reporte
                    }
                    else
                    {
                        MessageBox.Show("HA OCURRIDO UN ERROR" + Environment.NewLine + "AL REGISTRAR BAJA DE ACTIVO", "ERRORES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error:" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}