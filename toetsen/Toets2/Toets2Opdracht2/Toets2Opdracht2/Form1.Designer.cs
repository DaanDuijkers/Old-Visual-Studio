namespace Toets2Opdracht2
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
            this.lblAgeCheck = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBier = new System.Windows.Forms.Label();
            this.lblTafel = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.txbLeeftijd = new System.Windows.Forms.TextBox();
            this.txbAchternaam = new System.Windows.Forms.TextBox();
            this.txbRoepnaam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(210, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opdracht 2";
            // 
            // lblAgeCheck
            // 
            this.lblAgeCheck.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAgeCheck.Location = new System.Drawing.Point(12, 198);
            this.lblAgeCheck.Name = "lblAgeCheck";
            this.lblAgeCheck.Size = new System.Drawing.Size(333, 40);
            this.lblAgeCheck.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Roepnaam";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Leeftijd";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Achternaam";
            // 
            // lblBier
            // 
            this.lblBier.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBier.Location = new System.Drawing.Point(15, 332);
            this.lblBier.Name = "lblBier";
            this.lblBier.Size = new System.Drawing.Size(330, 103);
            this.lblBier.TabIndex = 5;
            // 
            // lblTafel
            // 
            this.lblTafel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTafel.Location = new System.Drawing.Point(425, 189);
            this.lblTafel.Name = "lblTafel";
            this.lblTafel.Size = new System.Drawing.Size(142, 246);
            this.lblTafel.TabIndex = 6;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(113, 468);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(113, 39);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClean.Location = new System.Drawing.Point(232, 468);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(113, 39);
            this.btnClean.TabIndex = 8;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // txbLeeftijd
            // 
            this.txbLeeftijd.Location = new System.Drawing.Point(143, 160);
            this.txbLeeftijd.Multiline = true;
            this.txbLeeftijd.Name = "txbLeeftijd";
            this.txbLeeftijd.Size = new System.Drawing.Size(253, 23);
            this.txbLeeftijd.TabIndex = 9;
            // 
            // txbAchternaam
            // 
            this.txbAchternaam.Location = new System.Drawing.Point(143, 119);
            this.txbAchternaam.Multiline = true;
            this.txbAchternaam.Name = "txbAchternaam";
            this.txbAchternaam.Size = new System.Drawing.Size(253, 23);
            this.txbAchternaam.TabIndex = 10;
            // 
            // txbRoepnaam
            // 
            this.txbRoepnaam.Location = new System.Drawing.Point(143, 83);
            this.txbRoepnaam.Multiline = true;
            this.txbRoepnaam.Name = "txbRoepnaam";
            this.txbRoepnaam.Size = new System.Drawing.Size(253, 23);
            this.txbRoepnaam.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 519);
            this.Controls.Add(this.txbRoepnaam);
            this.Controls.Add(this.txbAchternaam);
            this.Controls.Add(this.txbLeeftijd);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblTafel);
            this.Controls.Add(this.lblBier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAgeCheck);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Opdracht2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAgeCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBier;
        private System.Windows.Forms.Label lblTafel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.TextBox txbLeeftijd;
        private System.Windows.Forms.TextBox txbAchternaam;
        private System.Windows.Forms.TextBox txbRoepnaam;
    }
}

