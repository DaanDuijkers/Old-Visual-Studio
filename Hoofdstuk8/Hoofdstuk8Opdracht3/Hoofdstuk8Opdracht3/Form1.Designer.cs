namespace Hoofdstuk8Opdracht3
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
            this.lblOutput = new System.Windows.Forms.Label();
            this.txbGetal2 = new System.Windows.Forms.TextBox();
            this.txbGetal1 = new System.Windows.Forms.TextBox();
            this.btnRekenUit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lengte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Breedte:";
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOutput.Location = new System.Drawing.Point(110, 177);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(185, 63);
            this.lblOutput.TabIndex = 2;
            // 
            // txbGetal2
            // 
            this.txbGetal2.Location = new System.Drawing.Point(143, 90);
            this.txbGetal2.Multiline = true;
            this.txbGetal2.Name = "txbGetal2";
            this.txbGetal2.Size = new System.Drawing.Size(133, 33);
            this.txbGetal2.TabIndex = 3;
            // 
            // txbGetal1
            // 
            this.txbGetal1.Location = new System.Drawing.Point(143, 26);
            this.txbGetal1.Multiline = true;
            this.txbGetal1.Name = "txbGetal1";
            this.txbGetal1.Size = new System.Drawing.Size(133, 34);
            this.txbGetal1.TabIndex = 4;
            // 
            // btnRekenUit
            // 
            this.btnRekenUit.Location = new System.Drawing.Point(143, 274);
            this.btnRekenUit.Name = "btnRekenUit";
            this.btnRekenUit.Size = new System.Drawing.Size(108, 43);
            this.btnRekenUit.TabIndex = 5;
            this.btnRekenUit.Text = "Reken Uit!";
            this.btnRekenUit.UseVisualStyleBackColor = true;
            this.btnRekenUit.Click += new System.EventHandler(this.btnRekenUit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 351);
            this.Controls.Add(this.btnRekenUit);
            this.Controls.Add(this.txbGetal1);
            this.Controls.Add(this.txbGetal2);
            this.Controls.Add(this.lblOutput);
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
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txbGetal2;
        private System.Windows.Forms.TextBox txbGetal1;
        private System.Windows.Forms.Button btnRekenUit;
    }
}

