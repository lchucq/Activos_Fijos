namespace activosFijos.Rpt
{
    partial class rptAct
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOfi = new System.Windows.Forms.ComboBox();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.cbPar = new System.Windows.Forms.ComboBox();
            this.cbAdq = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dpIni = new System.Windows.Forms.DateTimePicker();
            this.dpFin = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chbFechas = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbEst = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Reportes de Activos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbEst);
            this.groupBox1.Controls.Add(this.chbFechas);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dpFin);
            this.groupBox1.Controls.Add(this.dpIni);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbAdq);
            this.groupBox1.Controls.Add(this.cbPar);
            this.groupBox1.Controls.Add(this.cbCat);
            this.groupBox1.Controls.Add(this.cbOfi);
            this.groupBox1.Controls.Add(this.btnPrev);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 237);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bateria de reportes Activos";
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(67)))));
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(171, 208);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(100, 23);
            this.btnPrev.TabIndex = 8;
            this.btnPrev.Text = "Previsualizar";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Oficina:";
            // 
            // cbOfi
            // 
            this.cbOfi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOfi.FormattingEnabled = true;
            this.cbOfi.Location = new System.Drawing.Point(200, 19);
            this.cbOfi.Name = "cbOfi";
            this.cbOfi.Size = new System.Drawing.Size(150, 21);
            this.cbOfi.TabIndex = 9;
            // 
            // cbCat
            // 
            this.cbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Location = new System.Drawing.Point(200, 46);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(150, 21);
            this.cbCat.TabIndex = 10;
            // 
            // cbPar
            // 
            this.cbPar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPar.FormattingEnabled = true;
            this.cbPar.Location = new System.Drawing.Point(200, 73);
            this.cbPar.Name = "cbPar";
            this.cbPar.Size = new System.Drawing.Size(150, 21);
            this.cbPar.TabIndex = 11;
            // 
            // cbAdq
            // 
            this.cbAdq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdq.FormattingEnabled = true;
            this.cbAdq.Location = new System.Drawing.Point(200, 100);
            this.cbAdq.Name = "cbAdq";
            this.cbAdq.Size = new System.Drawing.Size(150, 21);
            this.cbAdq.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tipo Depreciación:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tipo Ingreso:";
            // 
            // dpIni
            // 
            this.dpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpIni.Location = new System.Drawing.Point(116, 182);
            this.dpIni.Name = "dpIni";
            this.dpIni.Size = new System.Drawing.Size(100, 20);
            this.dpIni.TabIndex = 16;
            // 
            // dpFin
            // 
            this.dpFin.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFin.Location = new System.Drawing.Point(250, 182);
            this.dpFin.Name = "dpFin";
            this.dpFin.Size = new System.Drawing.Size(100, 20);
            this.dpFin.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(218, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Fin:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Inicio:";
            // 
            // chbFechas
            // 
            this.chbFechas.AutoSize = true;
            this.chbFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFechas.Location = new System.Drawing.Point(116, 159);
            this.chbFechas.Name = "chbFechas";
            this.chbFechas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbFechas.Size = new System.Drawing.Size(183, 17);
            this.chbFechas.TabIndex = 20;
            this.chbFechas.Text = "Filtrar por Fecha de Compra";
            this.chbFechas.UseVisualStyleBackColor = true;
            this.chbFechas.CheckedChanged += new System.EventHandler(this.chbFechas_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Estado:";
            // 
            // cbEst
            // 
            this.cbEst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEst.FormattingEnabled = true;
            this.cbEst.Location = new System.Drawing.Point(200, 127);
            this.cbEst.Name = "cbEst";
            this.cbEst.Size = new System.Drawing.Size(150, 21);
            this.cbEst.TabIndex = 21;
            // 
            // rptAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rptAct";
            this.Text = "rptAct";
            this.Load += new System.EventHandler(this.rptAct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dpFin;
        private System.Windows.Forms.DateTimePicker dpIni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAdq;
        private System.Windows.Forms.ComboBox cbPar;
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.ComboBox cbOfi;
        private System.Windows.Forms.CheckBox chbFechas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbEst;
    }
}