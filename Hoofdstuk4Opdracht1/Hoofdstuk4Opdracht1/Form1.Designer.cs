namespace Hoofdstuk4Opdracht1
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
            this.txbGetal1 = new System.Windows.Forms.TextBox();
            this.txbGetal2 = new System.Windows.Forms.TextBox();
            this.btnRekenUit = new System.Windows.Forms.Button();
            this.lblUitvoer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbGetal1
            // 
            this.txbGetal1.Location = new System.Drawing.Point(77, 22);
            this.txbGetal1.Name = "txbGetal1";
            this.txbGetal1.Size = new System.Drawing.Size(100, 22);
            this.txbGetal1.TabIndex = 0;
            // 
            // txbGetal2
            // 
            this.txbGetal2.Location = new System.Drawing.Point(252, 22);
            this.txbGetal2.Name = "txbGetal2";
            this.txbGetal2.Size = new System.Drawing.Size(100, 22);
            this.txbGetal2.TabIndex = 1;
            // 
            // btnRekenUit
            // 
            this.btnRekenUit.Location = new System.Drawing.Point(165, 65);
            this.btnRekenUit.Name = "btnRekenUit";
            this.btnRekenUit.Size = new System.Drawing.Size(102, 39);
            this.btnRekenUit.TabIndex = 2;
            this.btnRekenUit.Text = "Reken Uit";
            this.btnRekenUit.UseVisualStyleBackColor = true;
            this.btnRekenUit.Click += new System.EventHandler(this.btnRekenUit_Click);
            // 
            // lblUitvoer
            // 
            this.lblUitvoer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblUitvoer.Location = new System.Drawing.Point(74, 120);
            this.lblUitvoer.Name = "lblUitvoer";
            this.lblUitvoer.Size = new System.Drawing.Size(278, 132);
            this.lblUitvoer.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 272);
            this.Controls.Add(this.lblUitvoer);
            this.Controls.Add(this.btnRekenUit);
            this.Controls.Add(this.txbGetal2);
            this.Controls.Add(this.txbGetal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbGetal1;
        private System.Windows.Forms.TextBox txbGetal2;
        private System.Windows.Forms.Button btnRekenUit;
        private System.Windows.Forms.Label lblUitvoer;
    }
}

