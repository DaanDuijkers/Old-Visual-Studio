namespace Week14Demo
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnGenerateString = new System.Windows.Forms.Button();
            this.lbGenerate = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 12);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(224, 34);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnGenerateString
            // 
            this.btnGenerateString.Location = new System.Drawing.Point(242, 12);
            this.btnGenerateString.Name = "btnGenerateString";
            this.btnGenerateString.Size = new System.Drawing.Size(224, 34);
            this.btnGenerateString.TabIndex = 1;
            this.btnGenerateString.Text = "Generate String";
            this.btnGenerateString.UseVisualStyleBackColor = true;
            this.btnGenerateString.Click += new System.EventHandler(this.btnGenerateString_Click);
            // 
            // lbGenerate
            // 
            this.lbGenerate.FormattingEnabled = true;
            this.lbGenerate.ItemHeight = 25;
            this.lbGenerate.Location = new System.Drawing.Point(12, 56);
            this.lbGenerate.Name = "lbGenerate";
            this.lbGenerate.Size = new System.Drawing.Size(224, 454);
            this.lbGenerate.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 522);
            this.Controls.Add(this.lbGenerate);
            this.Controls.Add(this.btnGenerateString);
            this.Controls.Add(this.btnGenerate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnGenerateString;
        private System.Windows.Forms.ListBox lbGenerate;
    }
}

