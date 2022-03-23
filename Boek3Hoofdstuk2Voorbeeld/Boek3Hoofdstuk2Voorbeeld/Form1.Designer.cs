namespace Boek3Hoofdstuk2Voorbeeld
{
    partial class frmPersonen
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
            this.btnEinde = new System.Windows.Forms.Button();
            this.dtpGeboortedatum = new System.Windows.Forms.DateTimePicker();
            this.grpZoeken = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbGeboortedatum = new System.Windows.Forms.ComboBox();
            this.cmbAchternaam = new System.Windows.Forms.ComboBox();
            this.cmbRoepnaam = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbTussenvoegsel = new System.Windows.Forms.TextBox();
            this.txbAchternaam = new System.Windows.Forms.TextBox();
            this.txbVoorletters = new System.Windows.Forms.TextBox();
            this.txbRoepnaam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPersonen = new System.Windows.Forms.DataGridView();
            this.grpZoeken.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEinde
            // 
            this.btnEinde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEinde.BackColor = System.Drawing.Color.LightCoral;
            this.btnEinde.Location = new System.Drawing.Point(726, 403);
            this.btnEinde.Name = "btnEinde";
            this.btnEinde.Size = new System.Drawing.Size(75, 23);
            this.btnEinde.TabIndex = 0;
            this.btnEinde.Text = "Einde";
            this.btnEinde.UseVisualStyleBackColor = false;
            // 
            // dtpGeboortedatum
            // 
            this.dtpGeboortedatum.Location = new System.Drawing.Point(530, 43);
            this.dtpGeboortedatum.Name = "dtpGeboortedatum";
            this.dtpGeboortedatum.Size = new System.Drawing.Size(225, 22);
            this.dtpGeboortedatum.TabIndex = 28;
            // 
            // grpZoeken
            // 
            this.grpZoeken.Controls.Add(this.label8);
            this.grpZoeken.Controls.Add(this.cmbGeboortedatum);
            this.grpZoeken.Controls.Add(this.cmbAchternaam);
            this.grpZoeken.Controls.Add(this.cmbRoepnaam);
            this.grpZoeken.Controls.Add(this.label6);
            this.grpZoeken.Controls.Add(this.label7);
            this.grpZoeken.Location = new System.Drawing.Point(15, 90);
            this.grpZoeken.Name = "grpZoeken";
            this.grpZoeken.Size = new System.Drawing.Size(779, 66);
            this.grpZoeken.TabIndex = 27;
            this.grpZoeken.TabStop = false;
            this.grpZoeken.Text = "Zoeken";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Roepnaam";
            // 
            // cmbGeboortedatum
            // 
            this.cmbGeboortedatum.FormattingEnabled = true;
            this.cmbGeboortedatum.Location = new System.Drawing.Point(657, 21);
            this.cmbGeboortedatum.Name = "cmbGeboortedatum";
            this.cmbGeboortedatum.Size = new System.Drawing.Size(121, 24);
            this.cmbGeboortedatum.TabIndex = 13;
            // 
            // cmbAchternaam
            // 
            this.cmbAchternaam.FormattingEnabled = true;
            this.cmbAchternaam.Location = new System.Drawing.Point(350, 20);
            this.cmbAchternaam.Name = "cmbAchternaam";
            this.cmbAchternaam.Size = new System.Drawing.Size(188, 24);
            this.cmbAchternaam.TabIndex = 14;
            // 
            // cmbRoepnaam
            // 
            this.cmbRoepnaam.FormattingEnabled = true;
            this.cmbRoepnaam.Location = new System.Drawing.Point(89, 21);
            this.cmbRoepnaam.Name = "cmbRoepnaam";
            this.cmbRoepnaam.Size = new System.Drawing.Size(147, 24);
            this.cmbRoepnaam.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Achternaam";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(544, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Geboortedatum";
            // 
            // txbTussenvoegsel
            // 
            this.txbTussenvoegsel.Location = new System.Drawing.Point(246, 45);
            this.txbTussenvoegsel.Name = "txbTussenvoegsel";
            this.txbTussenvoegsel.Size = new System.Drawing.Size(100, 22);
            this.txbTussenvoegsel.TabIndex = 26;
            // 
            // txbAchternaam
            // 
            this.txbAchternaam.Location = new System.Drawing.Point(369, 45);
            this.txbAchternaam.Name = "txbAchternaam";
            this.txbAchternaam.Size = new System.Drawing.Size(147, 22);
            this.txbAchternaam.TabIndex = 25;
            // 
            // txbVoorletters
            // 
            this.txbVoorletters.Location = new System.Drawing.Point(130, 45);
            this.txbVoorletters.Name = "txbVoorletters";
            this.txbVoorletters.Size = new System.Drawing.Size(100, 22);
            this.txbVoorletters.TabIndex = 24;
            // 
            // txbRoepnaam
            // 
            this.txbRoepnaam.Location = new System.Drawing.Point(15, 45);
            this.txbRoepnaam.Name = "txbRoepnaam";
            this.txbRoepnaam.Size = new System.Drawing.Size(100, 22);
            this.txbRoepnaam.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Geboortedatum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Achternaam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Voorletters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tussenvoegsel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Roepnaam";
            // 
            // dgvPersonen
            // 
            this.dgvPersonen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonen.Location = new System.Drawing.Point(16, 174);
            this.dgvPersonen.Name = "dgvPersonen";
            this.dgvPersonen.RowTemplate.Height = 24;
            this.dgvPersonen.Size = new System.Drawing.Size(785, 212);
            this.dgvPersonen.TabIndex = 29;
            // 
            // frmPersonen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 438);
            this.Controls.Add(this.dtpGeboortedatum);
            this.Controls.Add(this.grpZoeken);
            this.Controls.Add(this.txbTussenvoegsel);
            this.Controls.Add(this.txbAchternaam);
            this.Controls.Add(this.txbVoorletters);
            this.Controls.Add(this.txbRoepnaam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPersonen);
            this.Controls.Add(this.btnEinde);
            this.Name = "frmPersonen";
            this.Text = "Personen";
            this.grpZoeken.ResumeLayout(false);
            this.grpZoeken.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEinde;
        private System.Windows.Forms.DateTimePicker dtpGeboortedatum;
        private System.Windows.Forms.GroupBox grpZoeken;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbGeboortedatum;
        private System.Windows.Forms.ComboBox cmbAchternaam;
        private System.Windows.Forms.ComboBox cmbRoepnaam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbTussenvoegsel;
        private System.Windows.Forms.TextBox txbAchternaam;
        private System.Windows.Forms.TextBox txbVoorletters;
        private System.Windows.Forms.TextBox txbRoepnaam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPersonen;
    }
}

