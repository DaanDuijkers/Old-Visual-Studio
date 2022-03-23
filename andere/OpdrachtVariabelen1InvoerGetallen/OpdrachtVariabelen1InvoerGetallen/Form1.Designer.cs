namespace OpdrachtVariabelen1InvoerGetallen
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
            this.txtGetal1 = new System.Windows.Forms.TextBox();
            this.btnGetal1 = new System.Windows.Forms.Button();
            this.lblGetal1 = new System.Windows.Forms.Label();
            this.txtGetal2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtGetal1
            // 
            this.txtGetal1.Location = new System.Drawing.Point(332, 101);
            this.txtGetal1.Multiline = true;
            this.txtGetal1.Name = "txtGetal1";
            this.txtGetal1.Size = new System.Drawing.Size(581, 41);
            this.txtGetal1.TabIndex = 0;
            this.txtGetal1.TextChanged += new System.EventHandler(this.txtGetal1_TextChanged);
            // 
            // btnGetal1
            // 
            this.btnGetal1.Location = new System.Drawing.Point(587, 193);
            this.btnGetal1.Name = "btnGetal1";
            this.btnGetal1.Size = new System.Drawing.Size(75, 23);
            this.btnGetal1.TabIndex = 1;
            this.btnGetal1.Text = "Click me!";
            this.btnGetal1.UseVisualStyleBackColor = true;
            this.btnGetal1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblGetal1
            // 
            this.lblGetal1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblGetal1.Location = new System.Drawing.Point(329, 252);
            this.lblGetal1.Name = "lblGetal1";
            this.lblGetal1.Size = new System.Drawing.Size(584, 47);
            this.lblGetal1.TabIndex = 2;
            // 
            // txtGetal2
            // 
            this.txtGetal2.Location = new System.Drawing.Point(332, 149);
            this.txtGetal2.Name = "txtGetal2";
            this.txtGetal2.Size = new System.Drawing.Size(581, 22);
            this.txtGetal2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 500);
            this.Controls.Add(this.txtGetal2);
            this.Controls.Add(this.lblGetal1);
            this.Controls.Add(this.btnGetal1);
            this.Controls.Add(this.txtGetal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGetal1;
        private System.Windows.Forms.Button btnGetal1;
        private System.Windows.Forms.Label lblGetal1;
        private System.Windows.Forms.TextBox txtGetal2;
    }
}

