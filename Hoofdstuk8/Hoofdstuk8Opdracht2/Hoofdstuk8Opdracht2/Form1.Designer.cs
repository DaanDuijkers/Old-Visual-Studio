namespace Hoofdstuk8Opdracht2
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
            this.txbLengte = new System.Windows.Forms.TextBox();
            this.txbBreedte = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnRekenUit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbLengte
            // 
            this.txbLengte.Location = new System.Drawing.Point(175, 26);
            this.txbLengte.Multiline = true;
            this.txbLengte.Name = "txbLengte";
            this.txbLengte.Size = new System.Drawing.Size(134, 34);
            this.txbLengte.TabIndex = 0;
            // 
            // txbBreedte
            // 
            this.txbBreedte.Location = new System.Drawing.Point(175, 92);
            this.txbBreedte.Multiline = true;
            this.txbBreedte.Name = "txbBreedte";
            this.txbBreedte.Size = new System.Drawing.Size(134, 34);
            this.txbBreedte.TabIndex = 1;
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOutput.Location = new System.Drawing.Point(134, 170);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(196, 61);
            this.lblOutput.TabIndex = 2;
            // 
            // btnRekenUit
            // 
            this.btnRekenUit.Location = new System.Drawing.Point(175, 259);
            this.btnRekenUit.Name = "btnRekenUit";
            this.btnRekenUit.Size = new System.Drawing.Size(113, 45);
            this.btnRekenUit.TabIndex = 3;
            this.btnRekenUit.Text = "Reken uit!";
            this.btnRekenUit.UseVisualStyleBackColor = true;
            this.btnRekenUit.Click += new System.EventHandler(this.btnRekenUit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lengte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Breedte:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 337);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRekenUit);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txbBreedte);
            this.Controls.Add(this.txbLengte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbLengte;
        private System.Windows.Forms.TextBox txbBreedte;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnRekenUit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

