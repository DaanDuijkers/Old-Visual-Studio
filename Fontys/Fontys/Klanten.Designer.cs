namespace Fontys
{
    partial class frmKlanten
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbAchternaam = new System.Windows.Forms.TextBox();
            this.txbVoornaam = new System.Windows.Forms.TextBox();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.btnAanpassen = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.gvKlant = new System.Windows.Forms.DataGridView();
            this.txbTussenvoegsel = new System.Windows.Forms.TextBox();
            this.lblTussenvoegsel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbAdres = new System.Windows.Forms.TextBox();
            this.txbTelefoon = new System.Windows.Forms.TextBox();
            this.txbWoonplaats = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbPostcode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvKlant)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Voornaam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Achternaam:";
            // 
            // txbAchternaam
            // 
            this.txbAchternaam.Location = new System.Drawing.Point(363, 31);
            this.txbAchternaam.Name = "txbAchternaam";
            this.txbAchternaam.Size = new System.Drawing.Size(168, 22);
            this.txbAchternaam.TabIndex = 2;
            // 
            // txbVoornaam
            // 
            this.txbVoornaam.Location = new System.Drawing.Point(15, 31);
            this.txbVoornaam.Name = "txbVoornaam";
            this.txbVoornaam.Size = new System.Drawing.Size(168, 22);
            this.txbVoornaam.TabIndex = 0;
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.BackColor = System.Drawing.Color.Lime;
            this.btnOpslaan.Location = new System.Drawing.Point(468, 129);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(75, 23);
            this.btnOpslaan.TabIndex = 8;
            this.btnOpslaan.Text = "Sla op";
            this.btnOpslaan.UseVisualStyleBackColor = false;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // btnAanpassen
            // 
            this.btnAanpassen.BackColor = System.Drawing.Color.Yellow;
            this.btnAanpassen.Location = new System.Drawing.Point(549, 129);
            this.btnAanpassen.Name = "btnAanpassen";
            this.btnAanpassen.Size = new System.Drawing.Size(75, 23);
            this.btnAanpassen.TabIndex = 9;
            this.btnAanpassen.Text = "Pas aan";
            this.btnAanpassen.UseVisualStyleBackColor = false;
            this.btnAanpassen.Click += new System.EventHandler(this.btnAanpassen_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.BackColor = System.Drawing.Color.Red;
            this.btnVerwijder.Location = new System.Drawing.Point(629, 129);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(75, 23);
            this.btnVerwijder.TabIndex = 10;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = false;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // gvKlant
            // 
            this.gvKlant.AllowUserToAddRows = false;
            this.gvKlant.AllowUserToDeleteRows = false;
            this.gvKlant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvKlant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvKlant.Location = new System.Drawing.Point(12, 170);
            this.gvKlant.Name = "gvKlant";
            this.gvKlant.ReadOnly = true;
            this.gvKlant.RowTemplate.Height = 24;
            this.gvKlant.Size = new System.Drawing.Size(693, 289);
            this.gvKlant.TabIndex = 11;
            this.gvKlant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvKlant_CellContentClick);
            // 
            // txbTussenvoegsel
            // 
            this.txbTussenvoegsel.Location = new System.Drawing.Point(189, 31);
            this.txbTussenvoegsel.Name = "txbTussenvoegsel";
            this.txbTussenvoegsel.Size = new System.Drawing.Size(168, 22);
            this.txbTussenvoegsel.TabIndex = 1;
            // 
            // lblTussenvoegsel
            // 
            this.lblTussenvoegsel.AutoSize = true;
            this.lblTussenvoegsel.Location = new System.Drawing.Point(186, 9);
            this.lblTussenvoegsel.Name = "lblTussenvoegsel";
            this.lblTussenvoegsel.Size = new System.Drawing.Size(108, 17);
            this.lblTussenvoegsel.TabIndex = 13;
            this.lblTussenvoegsel.Text = "Tussenvoegsel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Telefoon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Woonplaats:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Adres:";
            // 
            // txbAdres
            // 
            this.txbAdres.Location = new System.Drawing.Point(15, 89);
            this.txbAdres.Name = "txbAdres";
            this.txbAdres.Size = new System.Drawing.Size(168, 22);
            this.txbAdres.TabIndex = 4;
            // 
            // txbTelefoon
            // 
            this.txbTelefoon.Location = new System.Drawing.Point(363, 89);
            this.txbTelefoon.Name = "txbTelefoon";
            this.txbTelefoon.Size = new System.Drawing.Size(168, 22);
            this.txbTelefoon.TabIndex = 6;
            // 
            // txbWoonplaats
            // 
            this.txbWoonplaats.Location = new System.Drawing.Point(189, 89);
            this.txbWoonplaats.Name = "txbWoonplaats";
            this.txbWoonplaats.Size = new System.Drawing.Size(168, 22);
            this.txbWoonplaats.TabIndex = 5;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(537, 89);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(168, 22);
            this.txbEmail.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(534, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Email:";
            // 
            // txbPostcode
            // 
            this.txbPostcode.Location = new System.Drawing.Point(536, 31);
            this.txbPostcode.Name = "txbPostcode";
            this.txbPostcode.Size = new System.Drawing.Size(168, 22);
            this.txbPostcode.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(537, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Postcode:";
            // 
            // frmKlanten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 471);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbPostcode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbWoonplaats);
            this.Controls.Add(this.txbTelefoon);
            this.Controls.Add(this.txbAdres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTussenvoegsel);
            this.Controls.Add(this.txbTussenvoegsel);
            this.Controls.Add(this.gvKlant);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnAanpassen);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.txbVoornaam);
            this.Controls.Add(this.txbAchternaam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKlanten";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.gvKlant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbAchternaam;
        private System.Windows.Forms.TextBox txbVoornaam;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Button btnAanpassen;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.DataGridView gvKlant;
        private System.Windows.Forms.TextBox txbTussenvoegsel;
        private System.Windows.Forms.Label lblTussenvoegsel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbAdres;
        private System.Windows.Forms.TextBox txbTelefoon;
        private System.Windows.Forms.TextBox txbWoonplaats;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbPostcode;
        private System.Windows.Forms.Label label7;
    }
}