namespace opdracht23
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txbLengte = new System.Windows.Forms.TextBox();
            this.txbBreedte = new System.Windows.Forms.TextBox();
            this.btnBerekenOppervlakte = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lengte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Breedte:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Uitkomst:";
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblOutput.Location = new System.Drawing.Point(145, 143);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(68, 23);
            this.lblOutput.TabIndex = 3;
            // 
            // txbLengte
            // 
            this.txbLengte.Location = new System.Drawing.Point(145, 54);
            this.txbLengte.Name = "txbLengte";
            this.txbLengte.Size = new System.Drawing.Size(173, 22);
            this.txbLengte.TabIndex = 4;
            // 
            // txbBreedte
            // 
            this.txbBreedte.Location = new System.Drawing.Point(145, 89);
            this.txbBreedte.Name = "txbBreedte";
            this.txbBreedte.Size = new System.Drawing.Size(173, 22);
            this.txbBreedte.TabIndex = 5;
            this.txbBreedte.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnBerekenOppervlakte
            // 
            this.btnBerekenOppervlakte.Location = new System.Drawing.Point(61, 282);
            this.btnBerekenOppervlakte.Name = "btnBerekenOppervlakte";
            this.btnBerekenOppervlakte.Size = new System.Drawing.Size(105, 48);
            this.btnBerekenOppervlakte.TabIndex = 6;
            this.btnBerekenOppervlakte.Text = "Bereken\r\noppervlakte";
            this.btnBerekenOppervlakte.UseVisualStyleBackColor = true;
            this.btnBerekenOppervlakte.Click += new System.EventHandler(this.btnBerekenOppervlakte_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(213, 282);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 48);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 480);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBerekenOppervlakte);
            this.Controls.Add(this.txbBreedte);
            this.Controls.Add(this.txbLengte);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txbLengte;
        private System.Windows.Forms.TextBox txbBreedte;
        private System.Windows.Forms.Button btnBerekenOppervlakte;
        private System.Windows.Forms.Button btnBack;
    }
}

