namespace preExam
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
            this.btnAddTank = new System.Windows.Forms.Button();
            this.btnAddBrewery = new System.Windows.Forms.Button();
            this.txbAdd = new System.Windows.Forms.TextBox();
            this.lblIdBrewers = new System.Windows.Forms.Label();
            this.cmbBrewers = new System.Windows.Forms.ComboBox();
            this.cmbTanks = new System.Windows.Forms.ComboBox();
            this.lblIdTank = new System.Windows.Forms.Label();
            this.btnRequestTank = new System.Windows.Forms.Button();
            this.txbRequestTank = new System.Windows.Forms.TextBox();
            this.btnEmptyTank = new System.Windows.Forms.Button();
            this.btnMoveBeer = new System.Windows.Forms.Button();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.txbMoveBeer = new System.Windows.Forms.TextBox();
            this.btnBrewerInfo = new System.Windows.Forms.Button();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.gbAdd.SuspendLayout();
            this.gbControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAdd
            // 
            this.gbAdd.BackColor = System.Drawing.Color.PeachPuff;
            this.gbAdd.Controls.Add(this.btnAddTank);
            this.gbAdd.Controls.Add(this.btnAddBrewery);
            this.gbAdd.Controls.Add(this.txbAdd);
            this.gbAdd.Location = new System.Drawing.Point(11, 11);
            this.gbAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbAdd.Size = new System.Drawing.Size(376, 162);
            this.gbAdd.TabIndex = 1;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Add Brewery of Tank";
            // 
            // btnAddTank
            // 
            this.btnAddTank.Location = new System.Drawing.Point(56, 115);
            this.btnAddTank.Name = "btnAddTank";
            this.btnAddTank.Size = new System.Drawing.Size(257, 31);
            this.btnAddTank.TabIndex = 2;
            this.btnAddTank.Text = "Add tank";
            this.btnAddTank.UseVisualStyleBackColor = true;
            this.btnAddTank.Click += new System.EventHandler(this.btnAddTank_Click);
            // 
            // btnAddBrewery
            // 
            this.btnAddBrewery.Location = new System.Drawing.Point(56, 78);
            this.btnAddBrewery.Name = "btnAddBrewery";
            this.btnAddBrewery.Size = new System.Drawing.Size(257, 31);
            this.btnAddBrewery.TabIndex = 1;
            this.btnAddBrewery.Text = "Add brewery";
            this.btnAddBrewery.UseVisualStyleBackColor = true;
            this.btnAddBrewery.Click += new System.EventHandler(this.btnAddBrewery_Click);
            // 
            // txbAdd
            // 
            this.txbAdd.Location = new System.Drawing.Point(56, 44);
            this.txbAdd.Name = "txbAdd";
            this.txbAdd.Size = new System.Drawing.Size(257, 28);
            this.txbAdd.TabIndex = 0;
            // 
            // lblIdBrewers
            // 
            this.lblIdBrewers.AutoSize = true;
            this.lblIdBrewers.Location = new System.Drawing.Point(5, 14);
            this.lblIdBrewers.Name = "lblIdBrewers";
            this.lblIdBrewers.Size = new System.Drawing.Size(100, 24);
            this.lblIdBrewers.TabIndex = 0;
            this.lblIdBrewers.Text = "ID brewers";
            // 
            // cmbBrewers
            // 
            this.cmbBrewers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrewers.FormattingEnabled = true;
            this.cmbBrewers.Location = new System.Drawing.Point(9, 42);
            this.cmbBrewers.Name = "cmbBrewers";
            this.cmbBrewers.Size = new System.Drawing.Size(167, 30);
            this.cmbBrewers.TabIndex = 1;
            // 
            // cmbTanks
            // 
            this.cmbTanks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTanks.FormattingEnabled = true;
            this.cmbTanks.Location = new System.Drawing.Point(195, 42);
            this.cmbTanks.Name = "cmbTanks";
            this.cmbTanks.Size = new System.Drawing.Size(167, 30);
            this.cmbTanks.TabIndex = 2;
            // 
            // lblIdTank
            // 
            this.lblIdTank.AutoSize = true;
            this.lblIdTank.Location = new System.Drawing.Point(296, 14);
            this.lblIdTank.Name = "lblIdTank";
            this.lblIdTank.Size = new System.Drawing.Size(66, 24);
            this.lblIdTank.TabIndex = 3;
            this.lblIdTank.Text = "ID tank";
            // 
            // btnRequestTank
            // 
            this.btnRequestTank.Location = new System.Drawing.Point(9, 92);
            this.btnRequestTank.Name = "btnRequestTank";
            this.btnRequestTank.Size = new System.Drawing.Size(167, 34);
            this.btnRequestTank.TabIndex = 4;
            this.btnRequestTank.Text = "Request for tank";
            this.btnRequestTank.UseVisualStyleBackColor = true;
            this.btnRequestTank.Click += new System.EventHandler(this.btnRequestTank_Click);
            // 
            // txbRequestTank
            // 
            this.txbRequestTank.Location = new System.Drawing.Point(262, 98);
            this.txbRequestTank.Name = "txbRequestTank";
            this.txbRequestTank.Size = new System.Drawing.Size(100, 28);
            this.txbRequestTank.TabIndex = 5;
            // 
            // btnEmptyTank
            // 
            this.btnEmptyTank.Location = new System.Drawing.Point(9, 149);
            this.btnEmptyTank.Name = "btnEmptyTank";
            this.btnEmptyTank.Size = new System.Drawing.Size(167, 34);
            this.btnEmptyTank.TabIndex = 6;
            this.btnEmptyTank.Text = "Make tank empty";
            this.btnEmptyTank.UseVisualStyleBackColor = true;
            // 
            // btnMoveBeer
            // 
            this.btnMoveBeer.Location = new System.Drawing.Point(9, 207);
            this.btnMoveBeer.Name = "btnMoveBeer";
            this.btnMoveBeer.Size = new System.Drawing.Size(167, 34);
            this.btnMoveBeer.TabIndex = 7;
            this.btnMoveBeer.Text = "Move beer to";
            this.btnMoveBeer.UseVisualStyleBackColor = true;
            // 
            // gbControls
            // 
            this.gbControls.BackColor = System.Drawing.SystemColors.Info;
            this.gbControls.Controls.Add(this.txbMoveBeer);
            this.gbControls.Controls.Add(this.btnBrewerInfo);
            this.gbControls.Controls.Add(this.btnMoveBeer);
            this.gbControls.Controls.Add(this.btnEmptyTank);
            this.gbControls.Controls.Add(this.txbRequestTank);
            this.gbControls.Controls.Add(this.btnRequestTank);
            this.gbControls.Controls.Add(this.lblIdTank);
            this.gbControls.Controls.Add(this.cmbTanks);
            this.gbControls.Controls.Add(this.cmbBrewers);
            this.gbControls.Controls.Add(this.lblIdBrewers);
            this.gbControls.Location = new System.Drawing.Point(11, 194);
            this.gbControls.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbControls.Name = "gbControls";
            this.gbControls.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gbControls.Size = new System.Drawing.Size(376, 333);
            this.gbControls.TabIndex = 0;
            this.gbControls.TabStop = false;
            // 
            // txbMoveBeer
            // 
            this.txbMoveBeer.Location = new System.Drawing.Point(262, 213);
            this.txbMoveBeer.Name = "txbMoveBeer";
            this.txbMoveBeer.Size = new System.Drawing.Size(100, 28);
            this.txbMoveBeer.TabIndex = 9;
            // 
            // btnBrewerInfo
            // 
            this.btnBrewerInfo.Location = new System.Drawing.Point(9, 264);
            this.btnBrewerInfo.Name = "btnBrewerInfo";
            this.btnBrewerInfo.Size = new System.Drawing.Size(167, 34);
            this.btnBrewerInfo.TabIndex = 8;
            this.btnBrewerInfo.Text = "Show brewer info";
            this.btnBrewerInfo.UseVisualStyleBackColor = true;
            // 
            // lbOutput
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.ItemHeight = 22;
            this.lbOutput.Location = new System.Drawing.Point(404, 11);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(360, 510);
            this.lbOutput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 539);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.gbAdd);
            this.Controls.Add(this.gbControls);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            this.gbControls.ResumeLayout(false);
            this.gbControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.Button btnAddTank;
        private System.Windows.Forms.Button btnAddBrewery;
        private System.Windows.Forms.TextBox txbAdd;
        private System.Windows.Forms.Label lblIdBrewers;
        private System.Windows.Forms.ComboBox cmbBrewers;
        private System.Windows.Forms.ComboBox cmbTanks;
        private System.Windows.Forms.Label lblIdTank;
        private System.Windows.Forms.Button btnRequestTank;
        private System.Windows.Forms.TextBox txbRequestTank;
        private System.Windows.Forms.Button btnEmptyTank;
        private System.Windows.Forms.Button btnMoveBeer;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.TextBox txbMoveBeer;
        private System.Windows.Forms.Button btnBrewerInfo;
        private System.Windows.Forms.ListBox lbOutput;
    }
}

