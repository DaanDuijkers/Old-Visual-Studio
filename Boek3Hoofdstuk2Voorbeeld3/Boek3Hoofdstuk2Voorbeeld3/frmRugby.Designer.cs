namespace Boek3Hoofdstuk2Voorbeeld3
{
    partial class frmRugby
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTeamId = new System.Windows.Forms.Label();
            this.txbTrainer = new System.Windows.Forms.TextBox();
            this.txbTeamnaam = new System.Windows.Forms.TextBox();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.btnEerste = new System.Windows.Forms.Button();
            this.btnLaatste = new System.Windows.Forms.Button();
            this.btnVolgende = new System.Windows.Forms.Button();
            this.btnEinde = new System.Windows.Forms.Button();
            this.btnVorige = new System.Windows.Forms.Button();
            this.cmbKlasse = new System.Windows.Forms.ComboBox();
            this.cmbSoortRugby = new System.Windows.Forms.ComboBox();
            this.txbAantalSpelers = new System.Windows.Forms.TextBox();
            this.dgvSpelers = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpelers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teamnaam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trainer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Klasse:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soort Rugby:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Team ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(555, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Aantal Spelers:";
            // 
            // lblTeamId
            // 
            this.lblTeamId.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTeamId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTeamId.Location = new System.Drawing.Point(665, 14);
            this.lblTeamId.Name = "lblTeamId";
            this.lblTeamId.Size = new System.Drawing.Size(36, 21);
            this.lblTeamId.TabIndex = 6;
            this.lblTeamId.Text = "-";
            this.lblTeamId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbTrainer
            // 
            this.txbTrainer.Location = new System.Drawing.Point(412, 9);
            this.txbTrainer.Name = "txbTrainer";
            this.txbTrainer.Size = new System.Drawing.Size(121, 22);
            this.txbTrainer.TabIndex = 7;
            // 
            // txbTeamnaam
            // 
            this.txbTeamnaam.Location = new System.Drawing.Point(119, 9);
            this.txbTeamnaam.Name = "txbTeamnaam";
            this.txbTeamnaam.Size = new System.Drawing.Size(187, 22);
            this.txbTeamnaam.TabIndex = 8;
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnVoegToe.Location = new System.Drawing.Point(753, 13);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(26, 23);
            this.btnVoegToe.TabIndex = 9;
            this.btnVoegToe.Text = "+";
            this.btnVoegToe.UseVisualStyleBackColor = false;
            this.btnVoegToe.Click += new System.EventHandler(this.btnVoegToe_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.BackColor = System.Drawing.Color.LightCoral;
            this.btnVerwijder.Location = new System.Drawing.Point(785, 14);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(26, 23);
            this.btnVerwijder.TabIndex = 10;
            this.btnVerwijder.Text = "-";
            this.btnVerwijder.UseVisualStyleBackColor = false;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            this.btnVerwijder.MouseHover += new System.EventHandler(this.btnVerwijder_MouseHover);
            // 
            // btnEerste
            // 
            this.btnEerste.Location = new System.Drawing.Point(715, 45);
            this.btnEerste.Name = "btnEerste";
            this.btnEerste.Size = new System.Drawing.Size(32, 23);
            this.btnEerste.TabIndex = 11;
            this.btnEerste.Text = "<<";
            this.btnEerste.UseVisualStyleBackColor = true;
            this.btnEerste.Click += new System.EventHandler(this.btnEerste_Click);
            // 
            // btnLaatste
            // 
            this.btnLaatste.Location = new System.Drawing.Point(817, 45);
            this.btnLaatste.Name = "btnLaatste";
            this.btnLaatste.Size = new System.Drawing.Size(32, 23);
            this.btnLaatste.TabIndex = 12;
            this.btnLaatste.Text = ">>";
            this.btnLaatste.UseVisualStyleBackColor = true;
            // 
            // btnVolgende
            // 
            this.btnVolgende.Location = new System.Drawing.Point(785, 45);
            this.btnVolgende.Name = "btnVolgende";
            this.btnVolgende.Size = new System.Drawing.Size(26, 23);
            this.btnVolgende.TabIndex = 13;
            this.btnVolgende.Text = ">";
            this.btnVolgende.UseVisualStyleBackColor = true;
            // 
            // btnEinde
            // 
            this.btnEinde.BackColor = System.Drawing.Color.LightCoral;
            this.btnEinde.Location = new System.Drawing.Point(832, 483);
            this.btnEinde.Name = "btnEinde";
            this.btnEinde.Size = new System.Drawing.Size(75, 23);
            this.btnEinde.TabIndex = 14;
            this.btnEinde.Text = "Einde";
            this.btnEinde.UseVisualStyleBackColor = false;
            // 
            // btnVorige
            // 
            this.btnVorige.Location = new System.Drawing.Point(753, 45);
            this.btnVorige.Name = "btnVorige";
            this.btnVorige.Size = new System.Drawing.Size(26, 23);
            this.btnVorige.TabIndex = 15;
            this.btnVorige.Text = "<";
            this.btnVorige.UseVisualStyleBackColor = true;
            // 
            // cmbKlasse
            // 
            this.cmbKlasse.FormattingEnabled = true;
            this.cmbKlasse.Items.AddRange(new object[] {
            "Ere klasse",
            "Eerste klasse",
            "Tweede klasse",
            "Derde klasse",
            "Vierde klasse"});
            this.cmbKlasse.Location = new System.Drawing.Point(119, 47);
            this.cmbKlasse.Name = "cmbKlasse";
            this.cmbKlasse.Size = new System.Drawing.Size(121, 24);
            this.cmbKlasse.TabIndex = 16;
            // 
            // cmbSoortRugby
            // 
            this.cmbSoortRugby.FormattingEnabled = true;
            this.cmbSoortRugby.Items.AddRange(new object[] {
            "Rugby Union",
            "Rugby League",
            "Rugby Sevens",
            "Ten-a-side",
            "Touch Rugby"});
            this.cmbSoortRugby.Location = new System.Drawing.Point(412, 46);
            this.cmbSoortRugby.Name = "cmbSoortRugby";
            this.cmbSoortRugby.Size = new System.Drawing.Size(121, 24);
            this.cmbSoortRugby.TabIndex = 17;
            this.cmbSoortRugby.SelectedIndexChanged += new System.EventHandler(this.cmbSoortRugby_SelectedIndexChanged);
            // 
            // txbAantalSpelers
            // 
            this.txbAantalSpelers.Location = new System.Drawing.Point(665, 46);
            this.txbAantalSpelers.Name = "txbAantalSpelers";
            this.txbAantalSpelers.ReadOnly = true;
            this.txbAantalSpelers.Size = new System.Drawing.Size(35, 22);
            this.txbAantalSpelers.TabIndex = 18;
            // 
            // dgvSpelers
            // 
            this.dgvSpelers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpelers.Location = new System.Drawing.Point(15, 88);
            this.dgvSpelers.Name = "dgvSpelers";
            this.dgvSpelers.RowTemplate.Height = 24;
            this.dgvSpelers.Size = new System.Drawing.Size(892, 389);
            this.dgvSpelers.TabIndex = 19;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            // 
            // frmRugby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 518);
            this.Controls.Add(this.dgvSpelers);
            this.Controls.Add(this.txbAantalSpelers);
            this.Controls.Add(this.cmbSoortRugby);
            this.Controls.Add(this.cmbKlasse);
            this.Controls.Add(this.btnVorige);
            this.Controls.Add(this.btnEinde);
            this.Controls.Add(this.btnVolgende);
            this.Controls.Add(this.btnLaatste);
            this.Controls.Add(this.btnEerste);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnVoegToe);
            this.Controls.Add(this.txbTeamnaam);
            this.Controls.Add(this.txbTrainer);
            this.Controls.Add(this.lblTeamId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRugby";
            this.Text = "Rugby";
            this.Load += new System.EventHandler(this.frmRugby_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpelers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTeamId;
        private System.Windows.Forms.TextBox txbTrainer;
        private System.Windows.Forms.TextBox txbTeamnaam;
        private System.Windows.Forms.Button btnVoegToe;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Button btnEerste;
        private System.Windows.Forms.Button btnLaatste;
        private System.Windows.Forms.Button btnVolgende;
        private System.Windows.Forms.Button btnEinde;
        private System.Windows.Forms.Button btnVorige;
        private System.Windows.Forms.ComboBox cmbKlasse;
        private System.Windows.Forms.ComboBox cmbSoortRugby;
        private System.Windows.Forms.TextBox txbAantalSpelers;
        private System.Windows.Forms.DataGridView dgvSpelers;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

