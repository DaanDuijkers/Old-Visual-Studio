namespace dieren
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
            this.txbOutput = new System.Windows.Forms.TextBox();
            this.btnGaEten = new System.Windows.Forms.Button();
            this.btnOliefant = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbOutput
            // 
            this.txbOutput.Location = new System.Drawing.Point(109, 203);
            this.txbOutput.Multiline = true;
            this.txbOutput.Name = "txbOutput";
            this.txbOutput.Size = new System.Drawing.Size(240, 222);
            this.txbOutput.TabIndex = 0;
            // 
            // btnGaEten
            // 
            this.btnGaEten.Location = new System.Drawing.Point(36, 90);
            this.btnGaEten.Name = "btnGaEten";
            this.btnGaEten.Size = new System.Drawing.Size(77, 75);
            this.btnGaEten.TabIndex = 1;
            this.btnGaEten.Text = "ga eten";
            this.btnGaEten.UseVisualStyleBackColor = true;
            this.btnGaEten.Click += new System.EventHandler(this.btnGaEten_Click);
            // 
            // btnOliefant
            // 
            this.btnOliefant.Location = new System.Drawing.Point(137, 90);
            this.btnOliefant.Name = "btnOliefant";
            this.btnOliefant.Size = new System.Drawing.Size(86, 75);
            this.btnOliefant.TabIndex = 2;
            this.btnOliefant.Text = "oliefant";
            this.btnOliefant.UseVisualStyleBackColor = true;
            this.btnOliefant.Click += new System.EventHandler(this.btnOliefant_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(251, 90);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(82, 75);
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(356, 90);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 75);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 477);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnOliefant);
            this.Controls.Add(this.btnGaEten);
            this.Controls.Add(this.txbOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbOutput;
        private System.Windows.Forms.Button btnGaEten;
        private System.Windows.Forms.Button btnOliefant;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button button4;
    }
}

