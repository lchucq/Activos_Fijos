namespace activosFijos
{
    partial class addAct
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
            this.txtValRes = new System.Windows.Forms.TextBox();
            this.txtDepMes = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbOfi = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.txtNumCom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFecCom = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDepre = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAdqui = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "AÑADIR ACTIVO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtValRes);
            this.groupBox1.Controls.Add(this.txtDepMes);
            this.groupBox1.Controls.Add(this.txtCost);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbOfi);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbCat);
            this.groupBox1.Controls.Add(this.txtNumCom);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpFecCom);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbDepre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbAdqui);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 237);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Activo";
            // 
            // txtValRes
            // 
            this.txtValRes.Location = new System.Drawing.Point(107, 154);
            this.txtValRes.MaxLength = 10;
            this.txtValRes.Name = "txtValRes";
            this.txtValRes.Size = new System.Drawing.Size(100, 20);
            this.txtValRes.TabIndex = 10;
            this.txtValRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValRes.Leave += new System.EventHandler(this.txtValRes_Leave);
            // 
            // txtDepMes
            // 
            this.txtDepMes.Enabled = false;
            this.txtDepMes.Location = new System.Drawing.Point(321, 125);
            this.txtDepMes.MaxLength = 45;
            this.txtDepMes.Name = "txtDepMes";
            this.txtDepMes.Size = new System.Drawing.Size(100, 20);
            this.txtDepMes.TabIndex = 9;
            this.txtDepMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDepMes.Leave += new System.EventHandler(this.txtDepMes_Leave);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(107, 126);
            this.txtCost.MaxLength = 45;
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 8;
            this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCost.Leave += new System.EventHandler(this.txtCost_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Oficina:";
            // 
            // cbOfi
            // 
            this.cbOfi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOfi.DropDownWidth = 150;
            this.cbOfi.FormattingEnabled = true;
            this.cbOfi.Location = new System.Drawing.Point(107, 98);
            this.cbOfi.Name = "cbOfi";
            this.cbOfi.Size = new System.Drawing.Size(100, 21);
            this.cbOfi.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(218, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "Categoría:";
            // 
            // cbCat
            // 
            this.cbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCat.DropDownWidth = 150;
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Location = new System.Drawing.Point(303, 98);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(121, 21);
            this.cbCat.TabIndex = 7;
            // 
            // txtNumCom
            // 
            this.txtNumCom.Location = new System.Drawing.Point(107, 44);
            this.txtNumCom.MaxLength = 45;
            this.txtNumCom.Name = "txtNumCom";
            this.txtNumCom.Size = new System.Drawing.Size(100, 20);
            this.txtNumCom.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Comprobante:";
            // 
            // dtpFecCom
            // 
            this.dtpFecCom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecCom.Location = new System.Drawing.Point(323, 45);
            this.dtpFecCom.Name = "dtpFecCom";
            this.dtpFecCom.Size = new System.Drawing.Size(100, 20);
            this.dtpFecCom.TabIndex = 3;
            this.dtpFecCom.Value = new System.DateTime(2019, 4, 13, 2, 26, 15, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(218, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Depr Mesual:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Costo Compra:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Depreciación:";
            // 
            // cbDepre
            // 
            this.cbDepre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepre.DropDownWidth = 150;
            this.cbDepre.FormattingEnabled = true;
            this.cbDepre.Location = new System.Drawing.Point(106, 71);
            this.cbDepre.Name = "cbDepre";
            this.cbDepre.Size = new System.Drawing.Size(100, 21);
            this.cbDepre.TabIndex = 4;
            this.cbDepre.SelectedIndexChanged += new System.EventHandler(this.cbDepre_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tipo Adqui:";
            // 
            // cbAdqui
            // 
            this.cbAdqui.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdqui.DropDownWidth = 150;
            this.cbAdqui.FormattingEnabled = true;
            this.cbAdqui.Location = new System.Drawing.Point(302, 71);
            this.cbAdqui.Name = "cbAdqui";
            this.cbAdqui.Size = new System.Drawing.Size(121, 21);
            this.cbAdqui.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Val Residual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Compra:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(67)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(182, 192);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Añadir";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(107, 19);
            this.txtNom.MaxLength = 250;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(315, 20);
            this.txtNom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripción:";
            // 
            // addAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addAct";
            this.Text = "addAct";
            this.Load += new System.EventHandler(this.addAct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbOfi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.TextBox txtNumCom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFecCom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDepre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAdqui;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtValRes;
        private System.Windows.Forms.TextBox txtDepMes;
    }
}