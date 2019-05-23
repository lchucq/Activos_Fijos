using activosFijos.Rpt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static activosFijos.Program;

namespace activosFijos
{
    public partial class Menu : MetroFramework.Forms.MetroForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            addFrmPanel(new Home());
            hora.Text = DateTime.Now.ToString();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void addFrmPanel(Form frm)
        {
            if (pnMenu.Controls.Count > 0)
                pnMenu.Controls.RemoveAt(0);
            Form fh = frm as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            pnMenu.Controls.Add(fh);
            pnMenu.Tag = fh;
            fh.Show();
        }

        public void addFrmPanelExt(Form frm)
        {
            if (pnMenu.Controls.Count > 0)
                pnMenu.Controls.RemoveAt(0);
            Form fh = frm as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            pnMenu.Controls.Add(fh);
            pnMenu.Tag = fh;
            fh.Show();
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToString();
        }

        private void parametrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFrmPanel(new addPar());
        }

        private void ingresoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFrmPanel(new addUsu());
        }

        private void modificaciónUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFrmPanel(new busEditUsu());
        }

        private void ingresoRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFrmPanel(new addRol());
        }
        

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ingresoOficinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFrmPanel(new addOfi());
        }

        private void ingresoActivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFrmPanel(new addAct());
        }

        private void modificarActivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFrmPanel(new busEdiAct());
        }

        private void cálculoYDepreciacionActivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFrmPanel(new clcDepPrev());
        }

        private void ajusteDeActivosPorSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFrmPanel(new busOutAct());
        }

        private void activosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addFrmPanel(new rptAct());
        }

        private void depreciacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFrmPanel(new rptDep());
        }
    }
}
