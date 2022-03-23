namespace Hoofdstuk5opdracht5
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
            this.txbMaand = new System.Windows.Forms.TextBox();
            this.lblAankondiging = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnVerzend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbMaand
            // 
            this.txbMaand.Location = new System.Drawing.Point(140, 25);
            this.txbMaand.Name = "txbMaand";
            this.txbMaand.Size = new System.Drawing.Size(200, 22);
            this.txbMaand.TabIndex = 0;
            // 
            // lblAankondiging
            // 
            this.lblAankondiging.AutoSize = true;
            this.lblAankondiging.Location = new System.Drawing.Point(12, 28);
            this.lblAankondiging.Name = "lblAankondiging";
            this.lblAankondiging.Size = new System.Drawing.Size(122, 17);
            this.lblAankondiging.TabIndex = 1;
            this.lblAankondiging.Text = "Vul een Maand in:";
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(15, 133);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(325, 238);
            this.lblOutput.TabIndex = 2;
            // 
            // btnVerzend
            // 
            this.btnVerzend.Location = new System.Drawing.Point(140, 68);
            this.btnVerzend.Name = "btnVerzend";
            this.btnVerzend.Size = new System.Drawing.Size(75, 37);
            this.btnVerzend.TabIndex = 3;
            this.btnVerzend.Text = "Verzend";
            this.btnVerzend.UseVisualStyleBackColor = true;
            this.btnVerzend.Click += new System.EventHandler(this.btnVerzend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 402);
            this.Controls.Add(this.btnVerzend);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblAankondiging);
            this.Controls.Add(this.txbMaand);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbMaand;
        private System.Windows.Forms.Label lblAankondiging;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnVerzend;
    }
}

