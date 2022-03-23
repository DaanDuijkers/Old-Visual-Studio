namespace Class
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
            this.gbAccount = new System.Windows.Forms.GroupBox();
            this.lblCheckingAccount = new System.Windows.Forms.Label();
            this.lblSavingsAccount = new System.Windows.Forms.Label();
            this.lblCheckingBalance = new System.Windows.Forms.Label();
            this.lblSavingsBalance = new System.Windows.Forms.Label();
            this.lblBankAccount = new System.Windows.Forms.Label();
            this.rbCheckingAccount = new System.Windows.Forms.RadioButton();
            this.rbSavingsAccount = new System.Windows.Forms.RadioButton();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txbAmount = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.gbAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAccount
            // 
            this.gbAccount.Controls.Add(this.btnWithdraw);
            this.gbAccount.Controls.Add(this.btnDeposit);
            this.gbAccount.Controls.Add(this.txbAmount);
            this.gbAccount.Controls.Add(this.lblAmount);
            this.gbAccount.Controls.Add(this.rbSavingsAccount);
            this.gbAccount.Controls.Add(this.rbCheckingAccount);
            this.gbAccount.Controls.Add(this.lblBankAccount);
            this.gbAccount.Location = new System.Drawing.Point(12, 83);
            this.gbAccount.Name = "gbAccount";
            this.gbAccount.Size = new System.Drawing.Size(387, 333);
            this.gbAccount.TabIndex = 1;
            this.gbAccount.TabStop = false;
            this.gbAccount.Text = "Actions";
            // 
            // lblCheckingAccount
            // 
            this.lblCheckingAccount.AutoSize = true;
            this.lblCheckingAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckingAccount.Location = new System.Drawing.Point(34, 9);
            this.lblCheckingAccount.Name = "lblCheckingAccount";
            this.lblCheckingAccount.Size = new System.Drawing.Size(279, 25);
            this.lblCheckingAccount.TabIndex = 2;
            this.lblCheckingAccount.Text = "Checking Account Balance:";
            // 
            // lblSavingsAccount
            // 
            this.lblSavingsAccount.AutoSize = true;
            this.lblSavingsAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavingsAccount.Location = new System.Drawing.Point(34, 44);
            this.lblSavingsAccount.Name = "lblSavingsAccount";
            this.lblSavingsAccount.Size = new System.Drawing.Size(266, 25);
            this.lblSavingsAccount.TabIndex = 3;
            this.lblSavingsAccount.Text = "Savings Account Balance:";
            // 
            // lblCheckingBalance
            // 
            this.lblCheckingBalance.AutoSize = true;
            this.lblCheckingBalance.Location = new System.Drawing.Point(332, 9);
            this.lblCheckingBalance.Name = "lblCheckingBalance";
            this.lblCheckingBalance.Size = new System.Drawing.Size(50, 25);
            this.lblCheckingBalance.TabIndex = 4;
            this.lblCheckingBalance.Text = "0.00";
            // 
            // lblSavingsBalance
            // 
            this.lblSavingsBalance.AutoSize = true;
            this.lblSavingsBalance.Location = new System.Drawing.Point(332, 44);
            this.lblSavingsBalance.Name = "lblSavingsBalance";
            this.lblSavingsBalance.Size = new System.Drawing.Size(50, 25);
            this.lblSavingsBalance.TabIndex = 5;
            this.lblSavingsBalance.Text = "0.00";
            // 
            // lblBankAccount
            // 
            this.lblBankAccount.AutoSize = true;
            this.lblBankAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankAccount.Location = new System.Drawing.Point(35, 46);
            this.lblBankAccount.Name = "lblBankAccount";
            this.lblBankAccount.Size = new System.Drawing.Size(266, 25);
            this.lblBankAccount.TabIndex = 0;
            this.lblBankAccount.Text = "Please select a bank account";
            // 
            // rbCheckingAccount
            // 
            this.rbCheckingAccount.AutoSize = true;
            this.rbCheckingAccount.Checked = true;
            this.rbCheckingAccount.Location = new System.Drawing.Point(63, 86);
            this.rbCheckingAccount.Name = "rbCheckingAccount";
            this.rbCheckingAccount.Size = new System.Drawing.Size(203, 29);
            this.rbCheckingAccount.TabIndex = 1;
            this.rbCheckingAccount.TabStop = true;
            this.rbCheckingAccount.Text = "Checking Accounts";
            this.rbCheckingAccount.UseVisualStyleBackColor = true;
            // 
            // rbSavingsAccount
            // 
            this.rbSavingsAccount.AutoSize = true;
            this.rbSavingsAccount.Location = new System.Drawing.Point(63, 121);
            this.rbSavingsAccount.Name = "rbSavingsAccount";
            this.rbSavingsAccount.Size = new System.Drawing.Size(181, 29);
            this.rbSavingsAccount.TabIndex = 2;
            this.rbSavingsAccount.Text = "Savings Account";
            this.rbSavingsAccount.UseVisualStyleBackColor = true;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(35, 177);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(162, 25);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount in Euros:";
            // 
            // txbAmount
            // 
            this.txbAmount.Location = new System.Drawing.Point(63, 205);
            this.txbAmount.Name = "txbAmount";
            this.txbAmount.Size = new System.Drawing.Size(191, 30);
            this.txbAmount.TabIndex = 4;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(40, 256);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(92, 34);
            this.btnDeposit.TabIndex = 5;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(231, 256);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(104, 34);
            this.btnWithdraw.TabIndex = 6;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 431);
            this.Controls.Add(this.lblSavingsBalance);
            this.Controls.Add(this.lblCheckingBalance);
            this.Controls.Add(this.lblSavingsAccount);
            this.Controls.Add(this.lblCheckingAccount);
            this.Controls.Add(this.gbAccount);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbAccount.ResumeLayout(false);
            this.gbAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAccount;
        private System.Windows.Forms.Label lblCheckingAccount;
        private System.Windows.Forms.Label lblSavingsAccount;
        private System.Windows.Forms.Label lblCheckingBalance;
        private System.Windows.Forms.Label lblSavingsBalance;
        private System.Windows.Forms.RadioButton rbSavingsAccount;
        private System.Windows.Forms.RadioButton rbCheckingAccount;
        private System.Windows.Forms.Label lblBankAccount;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.TextBox txbAmount;
        private System.Windows.Forms.Label lblAmount;
    }
}

