namespace Hoofdstuk5Opdracht6
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
            this.txbMaand = new System.Windows.Forms.TextBox();
            this.btnVerzend = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vul een Maand in:";
            // 
            // txbMaand
            // 
            this.txbMaand.Location = new System.Drawing.Point(202, 29);
            this.txbMaand.Name = "txbMaand";
            this.txbMaand.Size = new System.Drawing.Size(185, 22);
            this.txbMaand.TabIndex = 1;
            // 
            // btnVerzend
            // 
            this.btnVerzend.Location = new System.Drawing.Point(156, 81);
            this.btnVerzend.Name = "btnVerzend";
            this.btnVerzend.Size = new System.Drawing.Size(94, 44);
            this.btnVerzend.TabIndex = 2;
            this.btnVerzend.Text = "Verzend";
            this.btnVerzend.UseVisualStyleBackColor = true;
            this.btnVerzend.Click += new System.EventHandler(this.btnVerzend_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(28, 149);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(359, 347);
            this.lblOutput.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 505);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnVerzend);
            this.Controls.Add(this.txbMaand);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMaand;
        private System.Windows.Forms.Button btnVerzend;
        private System.Windows.Forms.Label lblOutput;
    }
}

