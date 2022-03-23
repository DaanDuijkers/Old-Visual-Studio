namespace Hoofdstuk5Opdracht4
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
            this.lblInvoer = new System.Windows.Forms.Label();
            this.txbLeeftijd = new System.Windows.Forms.TextBox();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInvoer
            // 
            this.lblInvoer.AutoSize = true;
            this.lblInvoer.Location = new System.Drawing.Point(40, 27);
            this.lblInvoer.Name = "lblInvoer";
            this.lblInvoer.Size = new System.Drawing.Size(117, 17);
            this.lblInvoer.TabIndex = 0;
            this.lblInvoer.Text = "Voer je leeftijd in:";
            // 
            // txbLeeftijd
            // 
            this.txbLeeftijd.Location = new System.Drawing.Point(186, 21);
            this.txbLeeftijd.Name = "txbLeeftijd";
            this.txbLeeftijd.Size = new System.Drawing.Size(168, 22);
            this.txbLeeftijd.TabIndex = 1;
            // 
            // lblOutcome
            // 
            this.lblOutcome.Location = new System.Drawing.Point(12, 92);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(395, 149);
            this.lblOutcome.TabIndex = 2;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(151, 264);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(102, 41);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 317);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.txbLeeftijd);
            this.Controls.Add(this.lblInvoer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInvoer;
        private System.Windows.Forms.TextBox txbLeeftijd;
        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.Button btnCheck;
    }
}

