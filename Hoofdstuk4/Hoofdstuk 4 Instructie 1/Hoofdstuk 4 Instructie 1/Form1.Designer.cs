namespace Hoofdstuk_4_Instructie_1
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
            this.txbGetal = new System.Windows.Forms.TextBox();
            this.btnBreuk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(77, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Getal";
            // 
            // txbGetal
            // 
            this.txbGetal.Location = new System.Drawing.Point(239, 45);
            this.txbGetal.Name = "txbGetal";
            this.txbGetal.Size = new System.Drawing.Size(100, 22);
            this.txbGetal.TabIndex = 1;
            // 
            // btnBreuk
            // 
            this.btnBreuk.Location = new System.Drawing.Point(140, 130);
            this.btnBreuk.Name = "btnBreuk";
            this.btnBreuk.Size = new System.Drawing.Size(123, 56);
            this.btnBreuk.TabIndex = 2;
            this.btnBreuk.Text = "Breuk";
            this.btnBreuk.UseVisualStyleBackColor = true;
            this.btnBreuk.Click += new System.EventHandler(this.btnBreuk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 253);
            this.Controls.Add(this.btnBreuk);
            this.Controls.Add(this.txbGetal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbGetal;
        private System.Windows.Forms.Button btnBreuk;
    }
}

