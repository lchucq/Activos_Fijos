namespace activosFijos
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaciónUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoOficinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoActivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarActivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depreciacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cálculoYDepreciacionActivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajusteDeActivosPorSalidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hora = new MetroFramework.Controls.MetroLabel();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.pnMenu = new System.Windows.Forms.Panel();
            this.activosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.depreciacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.activosToolStripMenuItem,
            this.depreciacionToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(460, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoUsuarioToolStripMenuItem,
            this.modificaciónUsuarioToolStripMenuItem,
            this.ingresoRolToolStripMenuItem,
            this.ingresoOficinasToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // ingresoUsuarioToolStripMenuItem
            // 
            this.ingresoUsuarioToolStripMenuItem.Name = "ingresoUsuarioToolStripMenuItem";
            this.ingresoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ingresoUsuarioToolStripMenuItem.Text = "Ingreso Usuario";
            this.ingresoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.ingresoUsuarioToolStripMenuItem_Click);
            // 
            // modificaciónUsuarioToolStripMenuItem
            // 
            this.modificaciónUsuarioToolStripMenuItem.Name = "modificaciónUsuarioToolStripMenuItem";
            this.modificaciónUsuarioToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.modificaciónUsuarioToolStripMenuItem.Text = "Modificación Usuario";
            this.modificaciónUsuarioToolStripMenuItem.Click += new System.EventHandler(this.modificaciónUsuarioToolStripMenuItem_Click);
            // 
            // ingresoRolToolStripMenuItem
            // 
            this.ingresoRolToolStripMenuItem.Name = "ingresoRolToolStripMenuItem";
            this.ingresoRolToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ingresoRolToolStripMenuItem.Text = "Ingreso Rol";
            this.ingresoRolToolStripMenuItem.Click += new System.EventHandler(this.ingresoRolToolStripMenuItem_Click);
            // 
            // ingresoOficinasToolStripMenuItem
            // 
            this.ingresoOficinasToolStripMenuItem.Name = "ingresoOficinasToolStripMenuItem";
            this.ingresoOficinasToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ingresoOficinasToolStripMenuItem.Text = "Ingreso Oficinas";
            this.ingresoOficinasToolStripMenuItem.Click += new System.EventHandler(this.ingresoOficinasToolStripMenuItem_Click);
            // 
            // activosToolStripMenuItem
            // 
            this.activosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametrosToolStripMenuItem,
            this.ingresoActivoToolStripMenuItem,
            this.modificarActivoToolStripMenuItem});
            this.activosToolStripMenuItem.Name = "activosToolStripMenuItem";
            this.activosToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.activosToolStripMenuItem.Text = "Activos";
            // 
            // parametrosToolStripMenuItem
            // 
            this.parametrosToolStripMenuItem.Name = "parametrosToolStripMenuItem";
            this.parametrosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.parametrosToolStripMenuItem.Text = "Parametros";
            this.parametrosToolStripMenuItem.Click += new System.EventHandler(this.parametrosToolStripMenuItem_Click);
            // 
            // ingresoActivoToolStripMenuItem
            // 
            this.ingresoActivoToolStripMenuItem.Name = "ingresoActivoToolStripMenuItem";
            this.ingresoActivoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ingresoActivoToolStripMenuItem.Text = "Ingreso Activo";
            this.ingresoActivoToolStripMenuItem.Click += new System.EventHandler(this.ingresoActivoToolStripMenuItem_Click);
            // 
            // modificarActivoToolStripMenuItem
            // 
            this.modificarActivoToolStripMenuItem.Name = "modificarActivoToolStripMenuItem";
            this.modificarActivoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.modificarActivoToolStripMenuItem.Text = "Modificar Activo";
            this.modificarActivoToolStripMenuItem.Click += new System.EventHandler(this.modificarActivoToolStripMenuItem_Click);
            // 
            // depreciacionToolStripMenuItem
            // 
            this.depreciacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cálculoYDepreciacionActivosToolStripMenuItem,
            this.ajusteDeActivosPorSalidaToolStripMenuItem});
            this.depreciacionToolStripMenuItem.Name = "depreciacionToolStripMenuItem";
            this.depreciacionToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.depreciacionToolStripMenuItem.Text = "Depreciacion";
            // 
            // cálculoYDepreciacionActivosToolStripMenuItem
            // 
            this.cálculoYDepreciacionActivosToolStripMenuItem.Name = "cálculoYDepreciacionActivosToolStripMenuItem";
            this.cálculoYDepreciacionActivosToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.cálculoYDepreciacionActivosToolStripMenuItem.Text = "Cálculo y Depreciacion Activos";
            this.cálculoYDepreciacionActivosToolStripMenuItem.Click += new System.EventHandler(this.cálculoYDepreciacionActivosToolStripMenuItem_Click);
            // 
            // ajusteDeActivosPorSalidaToolStripMenuItem
            // 
            this.ajusteDeActivosPorSalidaToolStripMenuItem.Name = "ajusteDeActivosPorSalidaToolStripMenuItem";
            this.ajusteDeActivosPorSalidaToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.ajusteDeActivosPorSalidaToolStripMenuItem.Text = "Ajuste de Activos por Salida";
            this.ajusteDeActivosPorSalidaToolStripMenuItem.Click += new System.EventHandler(this.ajusteDeActivosPorSalidaToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activosToolStripMenuItem1,
            this.depreciacionesToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(67)))));
            this.hora.Location = new System.Drawing.Point(373, 380);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(81, 19);
            this.hora.TabIndex = 4;
            this.hora.Text = "metroLabel1";
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // pnMenu
            // 
            this.pnMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnMenu.Location = new System.Drawing.Point(23, 96);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(454, 281);
            this.pnMenu.TabIndex = 5;
            // 
            // activosToolStripMenuItem1
            // 
            this.activosToolStripMenuItem1.Name = "activosToolStripMenuItem1";
            this.activosToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.activosToolStripMenuItem1.Text = "Activos";
            this.activosToolStripMenuItem1.Click += new System.EventHandler(this.activosToolStripMenuItem1_Click);
            // 
            // depreciacionesToolStripMenuItem
            // 
            this.depreciacionesToolStripMenuItem.Name = "depreciacionesToolStripMenuItem";
            this.depreciacionesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.depreciacionesToolStripMenuItem.Text = "Depreciaciones";
            this.depreciacionesToolStripMenuItem.Click += new System.EventHandler(this.depreciacionesToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.hora);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu Activos Fijos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private MetroFramework.Controls.MetroLabel hora;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoActivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depreciacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaciónUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.ToolStripMenuItem ingresoOficinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarActivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cálculoYDepreciacionActivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajusteDeActivosPorSalidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem depreciacionesToolStripMenuItem;
    }
}