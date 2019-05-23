namespace activosFijos.Rpt
{
    partial class rptDep
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
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudAnn = new System.Windows.Forms.NumericUpDown();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dpIni = new System.Windows.Forms.DateTimePicker();
            this.dpFin = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Reportes de Depreciaciones";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dpFin);
            this.groupBox1.Controls.Add(this.dpIni);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Controls.Add(this.nudAnn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbMes);
            this.groupBox1.Controls.Add(this.btnPrev);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 206);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bateria de reportes Depreciaciones";
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(67)))));
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(171, 173);
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
            this.label2.Location = new System.Drawing.Point(32, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mes:";
            // 
            // cbMes
            // 
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Location = new System.Drawing.Point(76, 77);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(121, 21);
            this.cbMes.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Año:";
            // 
            // nudAnn
            // 
            this.nudAnn.Location = new System.Drawing.Point(76, 104);
            this.nudAnn.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudAnn.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudAnn.Name = "nudAnn";
            this.nudAnn.Size = new System.Drawing.Size(60, 20);
            this.nudAnn.TabIndex = 13;
            this.nudAnn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAnn.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(74, 32);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(131, 17);
            this.rb1.TabIndex = 14;
            this.rb1.TabStop = true;
            this.rb1.Text = "Depreciación Mensual";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(230, 32);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(130, 17);
            this.rb2.TabIndex = 15;
            this.rb2.TabStop = true;
            this.rb2.Text = "Depreciación por Baja";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(233, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(233, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Inicio:";
            // 
            // dpIni
            // 
            this.dpIni.Cursor = System.Windows.Forms.Cursors.Default;
            this.dpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpIni.Location = new System.Drawing.Point(285, 78);
            this.dpIni.Name = "dpIni";
            this.dpIni.Size = new System.Drawing.Size(100, 20);
            this.dpIni.TabIndex = 18;
            // 
            // dpFin
            // 
            this.dpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFin.Location = new System.Drawing.Point(285, 104);
            this.dpFin.Name = "dpFin";
            this.dpFin.Size = new System.Drawing.Size(100, 20);
            this.dpFin.TabIndex = 19;
            // 
            // rptDep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rptDep";
            this.Text = "rptDep";
            this.Load += new System.EventHandler(this.rptDep_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudAnn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.DateTimePicker dpFin;
        private System.Windows.Forms.DateTimePicker dpIni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}