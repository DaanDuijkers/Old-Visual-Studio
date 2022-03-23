namespace bankAccount
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
            this.lblName = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblStartingAmount = new System.Windows.Forms.Label();
            this.txbStartingAmount = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.txbAccountNr = new System.Windows.Forms.TextBox();
            this.btnAccount = new System.Windows.Forms.Button();
            this.lbBalance = new System.Windows.Forms.ListBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txbAmount = new System.Windows.Forms.TextBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(99, 13);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(254, 30);
            this.txbName.TabIndex = 1;
            // 
            // lblStartingAmount
            // 
            this.lblStartingAmount.AutoSize = true;
            this.lblStartingAmount.Location = new System.Drawing.Point(12, 101);
            this.lblStartingAmount.Name = "lblStartingAmount";
            this.lblStartingAmount.Size = new System.Drawing.Size(147, 25);
            this.lblStartingAmount.TabIndex = 3;
            this.lblStartingAmount.Text = "StartingAmount";
            // 
            // txbStartingAmount
            // 
            this.txbStartingAmount.Location = new System.Drawing.Point(165, 98);
            this.txbStartingAmount.Name = "txbStartingAmount";
            this.txbStartingAmount.Size = new System.Drawing.Size(188, 30);
            this.txbStartingAmount.TabIndex = 4;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(17, 61);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(114, 25);
            this.lblAccount.TabIndex = 5;
            this.lblAccount.Text = "Account Nr.";
            // 
            // txbAccountNr
            // 
            this.txbAccountNr.Location = new System.Drawing.Point(165, 56);
            this.txbAccountNr.Name = "txbAccountNr";
            this.txbAccountNr.Size = new System.Drawing.Size(188, 30);
            this.txbAccountNr.TabIndex = 6;
            // 
            // btnAccount
            // 
            this.btnAccount.Location = new System.Drawing.Point(387, 96);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(213, 34);
            this.btnAccount.TabIndex = 7;
            this.btnAccount.Text = "Create bank account";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // lbBalance
            // 
            this.lbBalance.FormattingEnabled = true;
            this.lbBalance.ItemHeight = 25;
            this.lbBalance.Location = new System.Drawing.Point(632, 13);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(305, 404);
            this.lbBalance.TabIndex = 8;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(13, 365);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(80, 25);
            this.lblAmount.TabIndex = 9;
            this.lblAmount.Text = "Amount";
            // 
            // txbAmount
            // 
            this.txbAmount.Location = new System.Drawing.Point(99, 360);
            this.txbAmount.Name = "txbAmount";
            this.txbAmount.Size = new System.Drawing.Size(188, 30);
            this.txbAmount.TabIndex = 10;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(337, 357);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(108, 33);
            this.btnWithdraw.TabIndex = 11;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(492, 358);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(108, 32);
            this.btnDeposit.TabIndex = 12;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 431);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.txbAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lbBalance);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.txbAccountNr);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.txbStartingAmount);
            this.Controls.Add(this.lblStartingAmount);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblStartingAmount;
        private System.Windows.Forms.TextBox txbStartingAmount;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TextBox txbAccountNr;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.ListBox lbBalance;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txbAmount;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
    }
}

