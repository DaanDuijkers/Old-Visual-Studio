namespace linkedList
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
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.lbSender = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txbSender = new System.Windows.Forms.TextBox();
            this.txbMessage = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.lbMessages = new System.Windows.Forms.ListBox();
            this.gbAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.btnAdd);
            this.gbAdd.Controls.Add(this.txbMessage);
            this.gbAdd.Controls.Add(this.txbSender);
            this.gbAdd.Controls.Add(this.lblMessage);
            this.gbAdd.Controls.Add(this.lbSender);
            this.gbAdd.Location = new System.Drawing.Point(12, 12);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(647, 201);
            this.gbAdd.TabIndex = 0;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Add";
            // 
            // lbSender
            // 
            this.lbSender.AutoSize = true;
            this.lbSender.Location = new System.Drawing.Point(51, 45);
            this.lbSender.Name = "lbSender";
            this.lbSender.Size = new System.Drawing.Size(77, 24);
            this.lbSender.TabIndex = 0;
            this.lbSender.Text = "Sender:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(55, 99);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(92, 24);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Message:";
            // 
            // txbSender
            // 
            this.txbSender.Location = new System.Drawing.Point(183, 41);
            this.txbSender.Name = "txbSender";
            this.txbSender.Size = new System.Drawing.Size(344, 28);
            this.txbSender.TabIndex = 2;
            // 
            // txbMessage
            // 
            this.txbMessage.Location = new System.Drawing.Point(183, 95);
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.Size = new System.Drawing.Size(344, 28);
            this.txbMessage.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(452, 145);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 33);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 244);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(32, 24);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID:";
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(84, 240);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(193, 28);
            this.txbID.TabIndex = 2;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(342, 239);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 31);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(453, 239);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 31);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(16, 308);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 31);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lbMessages
            // 
            this.lbMessages.FormattingEnabled = true;
            this.lbMessages.ItemHeight = 22;
            this.lbMessages.Location = new System.Drawing.Point(111, 308);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(548, 224);
            this.lbMessages.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 542);
            this.Controls.Add(this.lbMessages);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.gbAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbMessage;
        private System.Windows.Forms.TextBox txbSender;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lbSender;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ListBox lbMessages;
    }
}

