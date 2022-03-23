namespace HelloWorld6
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
            this.lblIndex = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnClick = new System.Windows.Forms.Button();
            this.txbinvoer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblIndex
            // 
            this.lblIndex.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblIndex.Location = new System.Drawing.Point(77, 59);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(100, 39);
            this.lblIndex.TabIndex = 0;
            this.lblIndex.Text = "Index";
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblOutput.Location = new System.Drawing.Point(180, 125);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(299, 60);
            this.lblOutput.TabIndex = 1;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(183, 231);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(225, 80);
            this.btnClick.TabIndex = 2;
            this.btnClick.Text = "Show Index";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnIndex_Click);
            // 
            // txbinvoer
            // 
            this.txbinvoer.Location = new System.Drawing.Point(183, 59);
            this.txbinvoer.Multiline = true;
            this.txbinvoer.Name = "txbinvoer";
            this.txbinvoer.Size = new System.Drawing.Size(111, 39);
            this.txbinvoer.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(491, 484);
            this.Controls.Add(this.txbinvoer);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblIndex);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.TextBox txbinvoer;
    }
}

