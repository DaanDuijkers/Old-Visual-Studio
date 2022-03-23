namespace Toets2Opdracht1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txbGetal2 = new System.Windows.Forms.TextBox();
            this.txbBerekening = new System.Windows.Forms.TextBox();
            this.txbGetal1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Math Operations";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name: your name\r\nOV:      your ov number\r\nClass:   your class\r\n";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(64, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(64, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Operator";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(64, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number";
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblOutput.Location = new System.Drawing.Point(167, 333);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(100, 23);
            this.lblOutput.TabIndex = 5;
            // 
            // txbGetal2
            // 
            this.txbGetal2.Location = new System.Drawing.Point(170, 255);
            this.txbGetal2.Multiline = true;
            this.txbGetal2.Name = "txbGetal2";
            this.txbGetal2.Size = new System.Drawing.Size(100, 23);
            this.txbGetal2.TabIndex = 6;
            // 
            // txbBerekening
            // 
            this.txbBerekening.Location = new System.Drawing.Point(200, 210);
            this.txbBerekening.Multiline = true;
            this.txbBerekening.Name = "txbBerekening";
            this.txbBerekening.Size = new System.Drawing.Size(35, 23);
            this.txbBerekening.TabIndex = 7;
            // 
            // txbGetal1
            // 
            this.txbGetal1.Location = new System.Drawing.Point(170, 168);
            this.txbGetal1.Multiline = true;
            this.txbGetal1.Name = "txbGetal1";
            this.txbGetal1.Size = new System.Drawing.Size(100, 23);
            this.txbGetal1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "=";
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClean.Location = new System.Drawing.Point(276, 386);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(110, 41);
            this.btnClean.TabIndex = 10;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnResult.Location = new System.Drawing.Point(160, 386);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(110, 41);
            this.btnResult.TabIndex = 11;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 453);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbGetal1);
            this.Controls.Add(this.txbBerekening);
            this.Controls.Add(this.txbGetal2);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Opdracht1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txbGetal2;
        private System.Windows.Forms.TextBox txbBerekening;
        private System.Windows.Forms.TextBox txbGetal1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnResult;
    }
}

