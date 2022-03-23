namespace Hoofdstuk6Opdracht1
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
            this.txbOutcome = new System.Windows.Forms.TextBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbOutcome
            // 
            this.txbOutcome.Location = new System.Drawing.Point(7, 12);
            this.txbOutcome.Multiline = true;
            this.txbOutcome.Name = "txbOutcome";
            this.txbOutcome.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbOutcome.Size = new System.Drawing.Size(184, 388);
            this.txbOutcome.TabIndex = 0;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(7, 406);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(184, 56);
            this.btnClick.TabIndex = 1;
            this.btnClick.Text = "Click me!";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 474);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.txbOutcome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbOutcome;
        private System.Windows.Forms.Button btnClick;
    }
}

