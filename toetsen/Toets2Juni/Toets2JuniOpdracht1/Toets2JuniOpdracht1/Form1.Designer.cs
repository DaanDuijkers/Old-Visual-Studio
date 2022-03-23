namespace Toets2JuniOpdracht1
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
            this.lblOpdracht1 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.btnUitvoeren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOpdracht1
            // 
            this.lblOpdracht1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOpdracht1.Location = new System.Drawing.Point(193, 20);
            this.lblOpdracht1.Name = "lblOpdracht1";
            this.lblOpdracht1.Size = new System.Drawing.Size(82, 24);
            this.lblOpdracht1.TabIndex = 0;
            this.lblOpdracht1.Text = "Opdracht 1";
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblInfo.Location = new System.Drawing.Point(12, 86);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(171, 60);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Naam: Daan Duijkers\r\nOv:     116545\r\nKlas:   41AAO";
            // 
            // lblOutcome
            // 
            this.lblOutcome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOutcome.Location = new System.Drawing.Point(88, 185);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(352, 100);
            this.lblOutcome.TabIndex = 2;
            // 
            // btnUitvoeren
            // 
            this.btnUitvoeren.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUitvoeren.Location = new System.Drawing.Point(196, 329);
            this.btnUitvoeren.Name = "btnUitvoeren";
            this.btnUitvoeren.Size = new System.Drawing.Size(103, 39);
            this.btnUitvoeren.TabIndex = 3;
            this.btnUitvoeren.Text = "Uitvoeren";
            this.btnUitvoeren.UseVisualStyleBackColor = false;
            this.btnUitvoeren.Click += new System.EventHandler(this.btnUitvoeren_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 404);
            this.Controls.Add(this.btnUitvoeren);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblOpdracht1);
            this.Name = "Form1";
            this.Text = "Opdracht1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOpdracht1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.Button btnUitvoeren;
    }
}

