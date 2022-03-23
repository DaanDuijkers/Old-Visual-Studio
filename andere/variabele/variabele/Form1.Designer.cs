namespace variabele
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
            this.btnclick = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnclick
            // 
            this.btnclick.Location = new System.Drawing.Point(35, 12);
            this.btnclick.Name = "btnclick";
            this.btnclick.Size = new System.Drawing.Size(913, 42);
            this.btnclick.TabIndex = 0;
            this.btnclick.Text = "click me";
            this.btnclick.UseVisualStyleBackColor = true;
            this.btnclick.Click += new System.EventHandler(this.btnclick_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOutput.Location = new System.Drawing.Point(32, 208);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(916, 36);
            this.lblOutput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 468);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnclick);
            this.Name = "Form1";
            this.Text = "Opdracht 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnclick;
        private System.Windows.Forms.Label lblOutput;
    }
}

