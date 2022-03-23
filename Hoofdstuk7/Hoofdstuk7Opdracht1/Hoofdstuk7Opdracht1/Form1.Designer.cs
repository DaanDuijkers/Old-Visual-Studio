namespace Hoofdstuk7Opdracht1
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
            this.txbBoxInvoer = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbBoxInvoer
            // 
            this.txbBoxInvoer.Location = new System.Drawing.Point(108, 63);
            this.txbBoxInvoer.Name = "txbBoxInvoer";
            this.txbBoxInvoer.Size = new System.Drawing.Size(232, 22);
            this.txbBoxInvoer.TabIndex = 0;
            this.txbBoxInvoer.TextChanged += new System.EventHandler(this.txbBoxInvoer_TextChanged);
            this.txbBoxInvoer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbBoxInvoer_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 181);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 98);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 446);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txbBoxInvoer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbBoxInvoer;
        private System.Windows.Forms.TextBox textBox1;
    }
}

