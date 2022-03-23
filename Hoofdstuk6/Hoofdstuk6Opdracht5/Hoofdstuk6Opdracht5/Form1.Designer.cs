namespace Hoofdstuk6Opdracht5
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
            this.btnUitkomst = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbGetal1
            // 
            this.txbGetal1.Location = new System.Drawing.Point(16, 21);
            this.txbGetal1.Name = "txbGetal1";
            this.txbGetal1.Size = new System.Drawing.Size(100, 22);
            this.txbGetal1.TabIndex = 0;
            // 
            // txbGetal2
            // 
            this.txbGetal2.Location = new System.Drawing.Point(145, 21);
            this.txbGetal2.Name = "txbGetal2";
            this.txbGetal2.Size = new System.Drawing.Size(100, 22);
            this.txbGetal2.TabIndex = 1;
            // 
            // btnUitkomst
            // 
            this.btnUitkomst.Location = new System.Drawing.Point(288, 13);
            this.btnUitkomst.Name = "btnUitkomst";
            this.btnUitkomst.Size = new System.Drawing.Size(81, 38);
            this.btnUitkomst.TabIndex = 2;
            this.btnUitkomst.Text = "=";
            this.btnUitkomst.UseVisualStyleBackColor = true;
            this.btnUitkomst.Click += new System.EventHandler(this.btnUitkomst_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblOutput.Location = new System.Drawing.Point(13, 54);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(410, 465);
            this.lblOutput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 525);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnUitkomst);
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
        private System.Windows.Forms.Button btnUitkomst;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label label1;
    }
}

