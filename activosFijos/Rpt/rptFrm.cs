using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace activosFijos.Rpt
{
    public partial class rptFrm : MetroFramework.Forms.MetroForm
    {
        string connString = File.ReadAllText(Application.StartupPath + "\\conn.dat");
        public DataTable dtSet, dtParam, dtSetEnc;
        public string nomRep, ds, dsEnc;
        public rptFrm()
        {
            InitializeComponent();
        }

        private void rptFrm_Load(object sender, EventArgs e)
        {
            RV.Reset();
            RV.LocalReport.EnableExternalImages = true;
            RV.LocalReport.ReportPath = nomRep;
            //foreach (RenderingExtension elemento in RV.LocalReport.ListRenderingExtensions())
            //{
            //    //para Excel palabra clave: EXCELOPENXML - PDF - WORDOPENXML
            //    if (elemento.Name == "WORDOPENXML")
            //    {
            //        //traemos la información del campo con sus respectivos flags
            //        FieldInfo infCampo = elemento.GetType().GetField("m_isVisible", BindingFlags.Instance | BindingFlags.NonPublic);
            //        //colocamos el valor de false a la extension
            //        infCampo.SetValue(elemento, false);
            //    }
            //}
            if (dtParam != null)
                foreach (DataRow dr in dtParam.Rows)
                    RV.LocalReport.SetParameters(new ReportParameter(dr[0].ToString(), dr[1].ToString()));
            if (dtSetEnc != null)
                RV.LocalReport.DataSources.Add(new ReportDataSource(dsEnc, dtSetEnc));
            RV.LocalReport.DataSources.Add(new ReportDataSource(ds, dtSet));
            RV.RefreshReport();
        }
    }
}
