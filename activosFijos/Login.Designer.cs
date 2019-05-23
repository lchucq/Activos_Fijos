namespace activosFijos
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUsu = new MetroFramework.Controls.MetroTextBox();
            this.txtPass = new MetroFramework.Controls.MetroTextBox();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.msgError = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // txtUsu
            // 
            // 
            // 
            // 
            this.txtUsu.CustomButton.Image = null;
            this.txtUsu.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.txtUsu.CustomButton.Name = "";
            this.txtUsu.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsu.CustomButton.TabIndex = 1;
            this.txtUsu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsu.CustomButton.UseSelectable = true;
            this.txtUsu.CustomButton.Visible = false;
            this.txtUsu.Lines = new string[0];
            this.txtUsu.Location = new System.Drawing.Point(77, 89);
            this.txtUsu.MaxLength = 45;
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.PasswordChar = '\0';
            this.txtUsu.PromptText = "Usuario";
            this.txtUsu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsu.SelectedText = "";
            this.txtUsu.SelectionLength = 0;
            this.txtUsu.SelectionStart = 0;
            this.txtUsu.ShortcutsEnabled = true;
            this.txtUsu.Size = new System.Drawing.Size(150, 23);
            this.txtUsu.TabIndex = 0;
            this.txtUsu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsu.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsu.UseSelectable = true;
            this.txtUsu.WaterMark = "Usuario";
            this.txtUsu.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPass
            // 
            // 
            // 
            // 
            this.txtPass.CustomButton.Image = null;
            this.txtPass.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.txtPass.CustomButton.Name = "";
            this.txtPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPass.CustomButton.TabIndex = 1;
            this.txtPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPass.CustomButton.UseSelectable = true;
            this.txtPass.CustomButton.Visible = false;
            this.txtPass.Lines = new string[0];
            this.txtPass.Location = new System.Drawing.Point(77, 145);
            this.txtPass.MaxLength = 30;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PromptText = "Contraseña";
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(150, 23);
            this.txtPass.TabIndex = 1;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPass.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPass.UseSelectable = true;
            this.txtPass.WaterMark = "Contraseña";
            this.txtPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(112, 174);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // msgError
            // 
            this.msgError.AutoSize = true;
            this.msgError.ForeColor = System.Drawing.Color.Maroon;
            this.msgError.Location = new System.Drawing.Point(77, 216);
            this.msgError.Name = "msgError";
            this.msgError.Size = new System.Drawing.Size(0, 0);
            this.msgError.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.msgError);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "LogIn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtUsu;
        private MetroFramework.Controls.MetroTextBox txtPass;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroLabel msgError;
    }
}

