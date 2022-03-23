namespace Hoofdstuk_4_instructie_2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txbGetal = new System.Windows.Forms.TextBox();
            this.btnBreuk = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(49, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Getal";
            // 
            // txbGetal
            // 
            this.txbGetal.Location = new System.Drawing.Point(244, 42);
            this.txbGetal.Name = "txbGetal";
            this.txbGetal.Size = new System.Drawing.Size(100, 22);
            this.txbGetal.TabIndex = 1;
            // 
            // btnBreuk
            // 
            this.btnBreuk.Location = new System.Drawing.Point(152, 142);
            this.btnBreuk.Name = "btnBreuk";
            this.btnBreuk.Size = new System.Drawing.Size(103, 48);
            this.btnBreuk.TabIndex = 2;
            this.btnBreuk.Text = "Breuk";
            this.btnBreuk.UseVisualStyleBackColor = true;
            this.btnBreuk.Click += new System.EventHandler(this.btnBreuk_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 253);
            this.Controls.Add(this.btnBreuk);
            this.Controls.Add(this.txbGetal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbGetal;
        private System.Windows.Forms.Button btnBreuk;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

