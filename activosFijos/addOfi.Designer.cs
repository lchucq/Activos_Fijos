namespace activosFijos
{
    partial class addOfi
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
            this.grdExist = new System.Windows.Forms.GroupBox();
            this.grdOfi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idOfi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomOfi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desOfi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grdExist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOfi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "OFICINAS";
            // 
            // grdExist
            // 
            this.grdExist.Controls.Add(this.grdOfi);
            this.grdExist.Location = new System.Drawing.Point(12, 109);
            this.grdExist.Name = "grdExist";
            this.grdExist.Size = new System.Drawing.Size(430, 165);
            this.grdExist.TabIndex = 4;
            this.grdExist.TabStop = false;
            this.grdExist.Text = "Oficinas Existentes";
            // 
            // grdOfi
            // 
            this.grdOfi.AllowUserToAddRows = false;
            this.grdOfi.AllowUserToDeleteRows = false;
            this.grdOfi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOfi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOfi,
            this.nomOfi,
            this.desOfi});
            this.grdOfi.Location = new System.Drawing.Point(4, 19);
            this.grdOfi.Name = "grdOfi";
            this.grdOfi.ReadOnly = true;
            this.grdOfi.Size = new System.Drawing.Size(426, 140);
            this.grdOfi.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 73);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva Oficina";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(67)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(328, 30);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Añadir";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(93, 19);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(230, 20);
            this.txtNom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // idOfi
            // 
            this.idOfi.DataPropertyName = "idOfi";
            this.idOfi.HeaderText = "Codigo";
            this.idOfi.Name = "idOfi";
            this.idOfi.ReadOnly = true;
            this.idOfi.Width = 80;
            // 
            // nomOfi
            // 
            this.nomOfi.DataPropertyName = "nomOfi";
            this.nomOfi.HeaderText = "Nombre";
            this.nomOfi.Name = "nomOfi";
            this.nomOfi.ReadOnly = true;
            this.nomOfi.Width = 150;
            // 
            // desOfi
            // 
            this.desOfi.DataPropertyName = "desOfi";
            this.desOfi.HeaderText = "Descripción";
            this.desOfi.Name = "desOfi";
            this.desOfi.ReadOnly = true;
            this.desOfi.Width = 150;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(93, 45);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(230, 20);
            this.txtDes.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripción:";
            // 
            // addOfi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdExist);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addOfi";
            this.Text = "addOfi";
            this.Load += new System.EventHandler(this.addOfi_Load);
            this.grdExist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOfi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grdExist;
        private System.Windows.Forms.DataGridView grdOfi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOfi;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomOfi;
        private System.Windows.Forms.DataGridViewTextBoxColumn desOfi;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Label label3;
    }
}