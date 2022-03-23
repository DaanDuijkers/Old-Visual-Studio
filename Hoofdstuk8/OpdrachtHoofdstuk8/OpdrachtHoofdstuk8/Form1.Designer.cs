namespace OpdrachtHoofdstuk8
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblCheck = new System.Windows.Forms.Label();
            this.lblLoop = new System.Windows.Forms.Label();
            this.txbLeeftijd = new System.Windows.Forms.TextBox();
            this.txbAchternaam = new System.Windows.Forms.TextBox();
            this.txbRoepnaam = new System.Windows.Forms.TextBox();
            this.btnUitvoeren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roepnaam:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Achternaam:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Leeftijd:";
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUser.Location = new System.Drawing.Point(12, 148);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(255, 33);
            this.lblUser.TabIndex = 3;
            // 
            // lblCheck
            // 
            this.lblCheck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCheck.Location = new System.Drawing.Point(12, 205);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(255, 60);
            this.lblCheck.TabIndex = 4;
            // 
            // lblLoop
            // 
            this.lblLoop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLoop.Location = new System.Drawing.Point(335, 148);
            this.lblLoop.Name = "lblLoop";
            this.lblLoop.Size = new System.Drawing.Size(164, 235);
            this.lblLoop.TabIndex = 5;
            // 
            // txbLeeftijd
            // 
            this.txbLeeftijd.Location = new System.Drawing.Point(161, 88);
            this.txbLeeftijd.Multiline = true;
            this.txbLeeftijd.Name = "txbLeeftijd";
            this.txbLeeftijd.Size = new System.Drawing.Size(177, 23);
            this.txbLeeftijd.TabIndex = 6;
            // 
            // txbAchternaam
            // 
            this.txbAchternaam.Location = new System.Drawing.Point(161, 49);
            this.txbAchternaam.Multiline = true;
            this.txbAchternaam.Name = "txbAchternaam";
            this.txbAchternaam.Size = new System.Drawing.Size(177, 23);
            this.txbAchternaam.TabIndex = 7;
            // 
            // txbRoepnaam
            // 
            this.txbRoepnaam.Location = new System.Drawing.Point(161, 9);
            this.txbRoepnaam.Multiline = true;
            this.txbRoepnaam.Name = "txbRoepnaam";
            this.txbRoepnaam.Size = new System.Drawing.Size(177, 23);
            this.txbRoepnaam.TabIndex = 8;
            // 
            // btnUitvoeren
            // 
            this.btnUitvoeren.Location = new System.Drawing.Point(57, 332);
            this.btnUitvoeren.Name = "btnUitvoeren";
            this.btnUitvoeren.Size = new System.Drawing.Size(176, 51);
            this.btnUitvoeren.TabIndex = 9;
            this.btnUitvoeren.Text = "Uitvoeren";
            this.btnUitvoeren.UseVisualStyleBackColor = true;
            this.btnUitvoeren.Click += new System.EventHandler(this.btnUitvoeren_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 402);
            this.Controls.Add(this.btnUitvoeren);
            this.Controls.Add(this.txbRoepnaam);
            this.Controls.Add(this.txbAchternaam);
            this.Controls.Add(this.txbLeeftijd);
            this.Controls.Add(this.lblLoop);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Label lblLoop;
        private System.Windows.Forms.TextBox txbLeeftijd;
        private System.Windows.Forms.TextBox txbAchternaam;
        private System.Windows.Forms.TextBox txbRoepnaam;
        private System.Windows.Forms.Button btnUitvoeren;
    }
}

