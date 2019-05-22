namespace activosFijos
{
    partial class clcDepPrev
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdView = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.idAct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomUsu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesVid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desUltDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMesAnn = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "CALCULO PREVIO DE DEPRECIACIONES";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMesAnn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.grdView);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(-1, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 254);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculo de Activos a Depreciar";
            // 
            // grdView
            // 
            this.grdView.AllowUserToAddRows = false;
            this.grdView.AllowUserToDeleteRows = false;
            this.grdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAct,
            this.nomUsu,
            this.valCom,
            this.mesVid,
            this.idPar,
            this.fecCom,
            this.desUltDep});
            this.grdView.Location = new System.Drawing.Point(2, 16);
            this.grdView.Name = "grdView";
            this.grdView.ReadOnly = true;
            this.grdView.ShowCellErrors = false;
            this.grdView.ShowEditingIcon = false;
            this.grdView.Size = new System.Drawing.Size(450, 205);
            this.grdView.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(67)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(380, 227);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Continuar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // idAct
            // 
            this.idAct.DataPropertyName = "idAct";
            this.idAct.HeaderText = "ID";
            this.idAct.MaxInputLength = 15;
            this.idAct.Name = "idAct";
            this.idAct.ReadOnly = true;
            this.idAct.Width = 30;
            // 
            // nomUsu
            // 
            this.nomUsu.DataPropertyName = "desAct";
            this.nomUsu.HeaderText = "Descripción";
            this.nomUsu.Name = "nomUsu";
            this.nomUsu.ReadOnly = true;
            this.nomUsu.Width = 150;
            // 
            // valCom
            // 
            this.valCom.DataPropertyName = "depMen";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.valCom.DefaultCellStyle = dataGridViewCellStyle4;
            this.valCom.HeaderText = "Depreciación Actual";
            this.valCom.MaxInputLength = 20;
            this.valCom.Name = "valCom";
            this.valCom.ReadOnly = true;
            this.valCom.Width = 80;
            // 
            // mesVid
            // 
            this.mesVid.DataPropertyName = "mesVid";
            this.mesVid.HeaderText = "mesVid";
            this.mesVid.Name = "mesVid";
            this.mesVid.ReadOnly = true;
            this.mesVid.Visible = false;
            this.mesVid.Width = 50;
            // 
            // idPar
            // 
            this.idPar.DataPropertyName = "idPar";
            this.idPar.HeaderText = "idPar";
            this.idPar.Name = "idPar";
            this.idPar.ReadOnly = true;
            this.idPar.Visible = false;
            this.idPar.Width = 50;
            // 
            // fecCom
            // 
            this.fecCom.DataPropertyName = "mesesDepre";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.NullValue = null;
            this.fecCom.DefaultCellStyle = dataGridViewCellStyle5;
            this.fecCom.HeaderText = "Meses ya Depreciado";
            this.fecCom.MaxInputLength = 15;
            this.fecCom.Name = "fecCom";
            this.fecCom.ReadOnly = true;
            this.fecCom.Width = 70;
            // 
            // desUltDep
            // 
            this.desUltDep.DataPropertyName = "monDepre";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0";
            this.desUltDep.DefaultCellStyle = dataGridViewCellStyle6;
            this.desUltDep.HeaderText = "Monto ya Depreciado";
            this.desUltDep.Name = "desUltDep";
            this.desUltDep.ReadOnly = true;
            this.desUltDep.Width = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "TOTAL A DEPRECIAR";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(307, 231);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Año y Mes";
            // 
            // lblMesAnn
            // 
            this.lblMesAnn.AutoSize = true;
            this.lblMesAnn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesAnn.Location = new System.Drawing.Point(78, 232);
            this.lblMesAnn.Name = "lblMesAnn";
            this.lblMesAnn.Size = new System.Drawing.Size(0, 13);
            this.lblMesAnn.TabIndex = 13;
            // 
            // clcDepPrev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "clcDepPrev";
            this.Text = "clcDepPrev";
            this.Load += new System.EventHandler(this.clcDepPrev_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdView;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomUsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn valCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesVid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPar;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn desUltDep;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMesAnn;
        private System.Windows.Forms.Label label3;
    }
}