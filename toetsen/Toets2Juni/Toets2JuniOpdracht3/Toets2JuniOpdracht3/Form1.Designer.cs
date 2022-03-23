namespace Toets2JuniOpdracht3
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
            this.lblRekenberwerking = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblGetal1 = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblGetal2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbGetal = new System.Windows.Forms.TextBox();
            this.txbOperator = new System.Windows.Forms.TextBox();
            this.txbGetal1 = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnUitvoeren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRekenberwerking
            // 
            this.lblRekenberwerking.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRekenberwerking.Location = new System.Drawing.Point(241, 40);
            this.lblRekenberwerking.Name = "lblRekenberwerking";
            this.lblRekenberwerking.Size = new System.Drawing.Size(140, 46);
            this.lblRekenberwerking.TabIndex = 0;
            this.lblRekenberwerking.Text = "Rekenbewerkin";
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblInfo.Location = new System.Drawing.Point(30, 116);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(213, 57);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Name: Daan Duijkers\r\nOV :    116545\r\nKlas:    41AAO";
            // 
            // lblGetal1
            // 
            this.lblGetal1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblGetal1.Location = new System.Drawing.Point(70, 240);
            this.lblGetal1.Name = "lblGetal1";
            this.lblGetal1.Size = new System.Drawing.Size(65, 40);
            this.lblGetal1.TabIndex = 2;
            this.lblGetal1.Text = "Getal1";
            // 
            // lblOperator
            // 
            this.lblOperator.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblOperator.Location = new System.Drawing.Point(192, 240);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(79, 40);
            this.lblOperator.TabIndex = 3;
            this.lblOperator.Text = "Operator";
            // 
            // lblGetal2
            // 
            this.lblGetal2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblGetal2.Location = new System.Drawing.Point(328, 240);
            this.lblGetal2.Name = "lblGetal2";
            this.lblGetal2.Size = new System.Drawing.Size(62, 40);
            this.lblGetal2.TabIndex = 4;
            this.lblGetal2.Text = "Getal2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "=";
            // 
            // txbGetal
            // 
            this.txbGetal.Location = new System.Drawing.Point(313, 297);
            this.txbGetal.Name = "txbGetal";
            this.txbGetal.Size = new System.Drawing.Size(100, 22);
            this.txbGetal.TabIndex = 6;
            // 
            // txbOperator
            // 
            this.txbOperator.Location = new System.Drawing.Point(181, 297);
            this.txbOperator.Name = "txbOperator";
            this.txbOperator.Size = new System.Drawing.Size(100, 22);
            this.txbOperator.TabIndex = 7;
            // 
            // txbGetal1
            // 
            this.txbGetal1.Location = new System.Drawing.Point(53, 297);
            this.txbGetal1.Name = "txbGetal1";
            this.txbGetal1.Size = new System.Drawing.Size(100, 22);
            this.txbGetal1.TabIndex = 8;
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblOutput.Location = new System.Drawing.Point(464, 289);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(100, 34);
            this.lblOutput.TabIndex = 9;
            // 
            // btnUitvoeren
            // 
            this.btnUitvoeren.BackColor = System.Drawing.SystemColors.Control;
            this.btnUitvoeren.Location = new System.Drawing.Point(279, 396);
            this.btnUitvoeren.Name = "btnUitvoeren";
            this.btnUitvoeren.Size = new System.Drawing.Size(111, 46);
            this.btnUitvoeren.TabIndex = 10;
            this.btnUitvoeren.Text = "Uitvoeren";
            this.btnUitvoeren.UseVisualStyleBackColor = false;
            this.btnUitvoeren.Click += new System.EventHandler(this.btnUitvoeren_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(602, 496);
            this.Controls.Add(this.btnUitvoeren);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txbGetal1);
            this.Controls.Add(this.txbOperator);
            this.Controls.Add(this.txbGetal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblGetal2);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblGetal1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblRekenberwerking);
            this.Name = "Form1";
            this.Text = "Opdracht3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRekenberwerking;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblGetal1;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblGetal2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbGetal;
        private System.Windows.Forms.TextBox txbOperator;
        private System.Windows.Forms.TextBox txbGetal1;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnUitvoeren;
    }
}

