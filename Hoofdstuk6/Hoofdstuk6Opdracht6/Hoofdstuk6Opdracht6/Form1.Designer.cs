namespace Hoofdstuk6Opdracht6
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
            this.txbGetal = new System.Windows.Forms.TextBox();
            this.txbInt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnUitkomst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbGetal
            // 
            this.txbGetal.Location = new System.Drawing.Point(12, 12);
            this.txbGetal.Name = "txbGetal";
            this.txbGetal.Size = new System.Drawing.Size(100, 22);
            this.txbGetal.TabIndex = 0;
            // 
            // txbInt
            // 
            this.txbInt.Location = new System.Drawing.Point(235, 12);
            this.txbInt.Name = "txbInt";
            this.txbInt.Size = new System.Drawing.Size(100, 22);
            this.txbInt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(118, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "bij de macht van";
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblOutput.Location = new System.Drawing.Point(12, 56);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(450, 458);
            this.lblOutput.TabIndex = 3;
            // 
            // btnUitkomst
            // 
            this.btnUitkomst.Location = new System.Drawing.Point(341, 12);
            this.btnUitkomst.Name = "btnUitkomst";
            this.btnUitkomst.Size = new System.Drawing.Size(121, 41);
            this.btnUitkomst.TabIndex = 4;
            this.btnUitkomst.Text = "=";
            this.btnUitkomst.UseVisualStyleBackColor = true;
            this.btnUitkomst.Click += new System.EventHandler(this.btnUitkomst_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 523);
            this.Controls.Add(this.btnUitkomst);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbInt);
            this.Controls.Add(this.txbGetal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbGetal;
        private System.Windows.Forms.TextBox txbInt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnUitkomst;
    }
}

