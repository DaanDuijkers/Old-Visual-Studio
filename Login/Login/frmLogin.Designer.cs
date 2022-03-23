namespace Login
{
    partial class frmLogin
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
            this.lblGebruikersnaam = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txbGebruikersnaam = new System.Windows.Forms.TextBox();
            this.txbWachtwoord = new System.Windows.Forms.TextBox();
            this.lblWachtwoord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGebruikersnaam
            // 
            this.lblGebruikersnaam.AutoSize = true;
            this.lblGebruikersnaam.Location = new System.Drawing.Point(42, 15);
            this.lblGebruikersnaam.Name = "lblGebruikersnaam";
            this.lblGebruikersnaam.Size = new System.Drawing.Size(117, 17);
            this.lblGebruikersnaam.TabIndex = 0;
            this.lblGebruikersnaam.Text = "Gebruikersnaam:";
            this.lblGebruikersnaam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(77, 154);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 42);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txbGebruikersnaam
            // 
            this.txbGebruikersnaam.Location = new System.Drawing.Point(45, 35);
            this.txbGebruikersnaam.Name = "txbGebruikersnaam";
            this.txbGebruikersnaam.Size = new System.Drawing.Size(191, 22);
            this.txbGebruikersnaam.TabIndex = 2;
            // 
            // txbWachtwoord
            // 
            this.txbWachtwoord.Location = new System.Drawing.Point(45, 107);
            this.txbWachtwoord.Name = "txbWachtwoord";
            this.txbWachtwoord.Size = new System.Drawing.Size(191, 22);
            this.txbWachtwoord.TabIndex = 3;
            // 
            // lblWachtwoord
            // 
            this.lblWachtwoord.AutoSize = true;
            this.lblWachtwoord.Location = new System.Drawing.Point(42, 87);
            this.lblWachtwoord.Name = "lblWachtwoord";
            this.lblWachtwoord.Size = new System.Drawing.Size(90, 17);
            this.lblWachtwoord.TabIndex = 4;
            this.lblWachtwoord.Text = "Wachtwoord:";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 225);
            this.Controls.Add(this.lblWachtwoord);
            this.Controls.Add(this.txbWachtwoord);
            this.Controls.Add(this.txbGebruikersnaam);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblGebruikersnaam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Text = "Inloggen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGebruikersnaam;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txbGebruikersnaam;
        private System.Windows.Forms.TextBox txbWachtwoord;
        private System.Windows.Forms.Label lblWachtwoord;
    }
}