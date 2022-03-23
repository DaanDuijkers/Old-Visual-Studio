
namespace Week12Assignment
{
    partial class PersonForm
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grbWorkshop = new System.Windows.Forms.GroupBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbClass = new System.Windows.Forms.TextBox();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPSN = new System.Windows.Forms.TextBox();
            this.grbWorkshop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(336, 210);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(94, 46);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 210);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 46);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grbWorkshop
            // 
            this.grbWorkshop.Controls.Add(this.txbEmail);
            this.grbWorkshop.Controls.Add(this.txbClass);
            this.grbWorkshop.Controls.Add(this.txbFirstName);
            this.grbWorkshop.Controls.Add(this.txbLastName);
            this.grbWorkshop.Controls.Add(this.label7);
            this.grbWorkshop.Controls.Add(this.label6);
            this.grbWorkshop.Controls.Add(this.label5);
            this.grbWorkshop.Controls.Add(this.label4);
            this.grbWorkshop.Controls.Add(this.label3);
            this.grbWorkshop.Controls.Add(this.cmbType);
            this.grbWorkshop.Controls.Add(this.label1);
            this.grbWorkshop.Controls.Add(this.txbPSN);
            this.grbWorkshop.Location = new System.Drawing.Point(12, 12);
            this.grbWorkshop.Name = "grbWorkshop";
            this.grbWorkshop.Size = new System.Drawing.Size(418, 192);
            this.grbWorkshop.TabIndex = 3;
            this.grbWorkshop.TabStop = false;
            this.grbWorkshop.Text = "Workshop Data";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(212, 160);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(200, 24);
            this.txbEmail.TabIndex = 19;
            // 
            // txbClass
            // 
            this.txbClass.Location = new System.Drawing.Point(6, 160);
            this.txbClass.Name = "txbClass";
            this.txbClass.Size = new System.Drawing.Size(200, 24);
            this.txbClass.TabIndex = 18;
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(6, 102);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(200, 24);
            this.txbFirstName.TabIndex = 17;
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(212, 102);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(200, 24);
            this.txbLastName.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Class:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Last name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "First name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type:";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Teacher",
            "Student"});
            this.cmbType.Location = new System.Drawing.Point(212, 45);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(200, 26);
            this.cmbType.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "PSN:";
            // 
            // txbPSN
            // 
            this.txbPSN.Location = new System.Drawing.Point(6, 45);
            this.txbPSN.Name = "txbPSN";
            this.txbPSN.Size = new System.Drawing.Size(200, 24);
            this.txbPSN.TabIndex = 0;
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 263);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grbWorkshop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PersonForm";
            this.Text = "PersonForm";
            this.grbWorkshop.ResumeLayout(false);
            this.grbWorkshop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grbWorkshop;
        private System.Windows.Forms.TextBox txbClass;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPSN;
        private System.Windows.Forms.TextBox txbEmail;
    }
}