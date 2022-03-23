namespace week14Assignment
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
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbStudentNr = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudentNr = new System.Windows.Forms.Label();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(12, 76);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(200, 30);
            this.txbName.TabIndex = 0;
            // 
            // txbStudentNr
            // 
            this.txbStudentNr.Location = new System.Drawing.Point(12, 178);
            this.txbStudentNr.Name = "txbStudentNr";
            this.txbStudentNr.Size = new System.Drawing.Size(200, 30);
            this.txbStudentNr.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 25);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblStudentNr
            // 
            this.lblStudentNr.AutoSize = true;
            this.lblStudentNr.Location = new System.Drawing.Point(12, 150);
            this.lblStudentNr.Name = "lblStudentNr";
            this.lblStudentNr.Size = new System.Drawing.Size(102, 25);
            this.lblStudentNr.TabIndex = 3;
            this.lblStudentNr.Text = "Studentnr.";
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(41, 380);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(132, 36);
            this.btnAddMember.TabIndex = 4;
            this.btnAddMember.Text = "Add member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.ItemHeight = 25;
            this.lbInfo.Location = new System.Drawing.Point(227, 12);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(752, 404);
            this.lbInfo.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 430);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.lblStudentNr);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txbStudentNr);
            this.Controls.Add(this.txbName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbStudentNr;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStudentNr;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.ListBox lbInfo;
    }
}

