namespace Hoofdstuk6ExtraOpdracht2
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
            this.lblFah = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbFah = new System.Windows.Forms.TextBox();
            this.txbCel = new System.Windows.Forms.TextBox();
            this.btnCel = new System.Windows.Forms.Button();
            this.btnFah = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voer de hoeveelheid in Celsius in:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "In Fahrenheit:";
            // 
            // lblFah
            // 
            this.lblFah.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblFah.Location = new System.Drawing.Point(317, 80);
            this.lblFah.Name = "lblFah";
            this.lblFah.Size = new System.Drawing.Size(67, 36);
            this.lblFah.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Voer de hoeveelheid in Fahrenheit in:";
            // 
            // lblCel
            // 
            this.lblCel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCel.Location = new System.Drawing.Point(317, 173);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(67, 36);
            this.lblCel.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "In Celsius:";
            // 
            // txbFah
            // 
            this.txbFah.Location = new System.Drawing.Point(317, 132);
            this.txbFah.Multiline = true;
            this.txbFah.Name = "txbFah";
            this.txbFah.Size = new System.Drawing.Size(67, 38);
            this.txbFah.TabIndex = 6;
            // 
            // txbCel
            // 
            this.txbCel.Location = new System.Drawing.Point(317, 39);
            this.txbCel.Multiline = true;
            this.txbCel.Name = "txbCel";
            this.txbCel.Size = new System.Drawing.Size(67, 38);
            this.txbCel.TabIndex = 7;
            // 
            // btnCel
            // 
            this.btnCel.Location = new System.Drawing.Point(247, 269);
            this.btnCel.Name = "btnCel";
            this.btnCel.Size = new System.Drawing.Size(137, 48);
            this.btnCel.TabIndex = 8;
            this.btnCel.Text = "Van Fah naar Cel";
            this.btnCel.UseVisualStyleBackColor = true;
            this.btnCel.Click += new System.EventHandler(this.btnCel_Click);
            // 
            // btnFah
            // 
            this.btnFah.Location = new System.Drawing.Point(94, 269);
            this.btnFah.Name = "btnFah";
            this.btnFah.Size = new System.Drawing.Size(137, 48);
            this.btnFah.TabIndex = 9;
            this.btnFah.Text = "Van Cel naar Fah";
            this.btnFah.UseVisualStyleBackColor = true;
            this.btnFah.Click += new System.EventHandler(this.btnFah_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 358);
            this.Controls.Add(this.btnFah);
            this.Controls.Add(this.btnCel);
            this.Controls.Add(this.txbCel);
            this.Controls.Add(this.txbFah);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFah);
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
        private System.Windows.Forms.Label lblFah;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbFah;
        private System.Windows.Forms.TextBox txbCel;
        private System.Windows.Forms.Button btnCel;
        private System.Windows.Forms.Button btnFah;
    }
}

