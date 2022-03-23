namespace week6Exam
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
            this.btnFirstAssignment = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblIncrement = new System.Windows.Forms.Label();
            this.tbBase = new System.Windows.Forms.TextBox();
            this.tbIncrement = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFirstAssignment
            // 
            this.btnFirstAssignment.Location = new System.Drawing.Point(20, 20);
            this.btnFirstAssignment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFirstAssignment.Name = "btnFirstAssignment";
            this.btnFirstAssignment.Size = new System.Drawing.Size(262, 50);
            this.btnFirstAssignment.TabIndex = 0;
            this.btnFirstAssignment.Text = "button for first assignment";
            this.btnFirstAssignment.UseVisualStyleBackColor = true;
            this.btnFirstAssignment.Click += new System.EventHandler(this.btnFirstAssignment_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.ItemHeight = 25;
            this.lbInfo.Location = new System.Drawing.Point(316, 20);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(219, 504);
            this.lbInfo.TabIndex = 1;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(12, 362);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(128, 25);
            this.lblBase.TabIndex = 2;
            this.lblBase.Text = "Base number";
            // 
            // lblIncrement
            // 
            this.lblIncrement.AutoSize = true;
            this.lblIncrement.Location = new System.Drawing.Point(12, 418);
            this.lblIncrement.Name = "lblIncrement";
            this.lblIncrement.Size = new System.Drawing.Size(140, 25);
            this.lblIncrement.TabIndex = 3;
            this.lblIncrement.Text = "First Increment";
            // 
            // tbBase
            // 
            this.tbBase.Location = new System.Drawing.Point(146, 357);
            this.tbBase.Name = "tbBase";
            this.tbBase.Size = new System.Drawing.Size(148, 30);
            this.tbBase.TabIndex = 4;
            // 
            // tbIncrement
            // 
            this.tbIncrement.Location = new System.Drawing.Point(158, 415);
            this.tbIncrement.Name = "tbIncrement";
            this.tbIncrement.Size = new System.Drawing.Size(136, 30);
            this.tbIncrement.TabIndex = 5;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(13, 472);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(281, 51);
            this.btnGo.TabIndex = 6;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 538);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.tbIncrement);
            this.Controls.Add(this.tbBase);
            this.Controls.Add(this.lblIncrement);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btnFirstAssignment);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFirstAssignment;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblIncrement;
        private System.Windows.Forms.TextBox tbBase;
        private System.Windows.Forms.TextBox tbIncrement;
        private System.Windows.Forms.Button btnGo;
    }
}

