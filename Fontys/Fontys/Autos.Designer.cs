namespace Fontys
{
    partial class frmAutos
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
            this.txbMerk = new System.Windows.Forms.TextBox();
            this.gvAuto = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKleur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPrijs = new System.Windows.Forms.TextBox();
            this.txbKenteken = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // txbMerk
            // 
            this.txbMerk.Location = new System.Drawing.Point(15, 38);
            this.txbMerk.Name = "txbMerk";
            this.txbMerk.Size = new System.Drawing.Size(129, 22);
            this.txbMerk.TabIndex = 0;
            // 
            // gvAuto
            // 
            this.gvAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAuto.Location = new System.Drawing.Point(12, 122);
            this.gvAuto.Name = "gvAuto";
            this.gvAuto.RowTemplate.Height = 24;
            this.gvAuto.Size = new System.Drawing.Size(624, 319);
            this.gvAuto.TabIndex = 6;
            this.gvAuto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvAuto_CellContentClick);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Lime;
            this.btnInsert.Location = new System.Drawing.Point(379, 77);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(76, 29);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Oplaan";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdate.Location = new System.Drawing.Point(461, 77);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(76, 29);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Bijwerken";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(543, 77);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 29);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Verwijderen";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Merk auto:";
            // 
            // cmbKleur
            // 
            this.cmbKleur.FormattingEnabled = true;
            this.cmbKleur.Items.AddRange(new object[] {
            "Rood",
            "Geel",
            "Blauw",
            "Paars",
            "Oranje",
            "Groen",
            "Wit",
            "Zwart",
            "Grijs"});
            this.cmbKleur.Location = new System.Drawing.Point(340, 38);
            this.cmbKleur.Name = "cmbKleur";
            this.cmbKleur.Size = new System.Drawing.Size(129, 24);
            this.cmbKleur.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kleur:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prijs:";
            // 
            // txbPrijs
            // 
            this.txbPrijs.Location = new System.Drawing.Point(507, 38);
            this.txbPrijs.Name = "txbPrijs";
            this.txbPrijs.Size = new System.Drawing.Size(129, 22);
            this.txbPrijs.TabIndex = 2;
            // 
            // txbKenteken
            // 
            this.txbKenteken.Location = new System.Drawing.Point(177, 38);
            this.txbKenteken.Name = "txbKenteken";
            this.txbKenteken.Size = new System.Drawing.Size(129, 22);
            this.txbKenteken.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kenteken";
            // 
            // frmAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 453);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbKenteken);
            this.Controls.Add(this.txbPrijs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKleur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.gvAuto);
            this.Controls.Add(this.txbMerk);
            this.Name = "frmAutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Autos";
            ((System.ComponentModel.ISupportInitialize)(this.gvAuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbMerk;
        private System.Windows.Forms.DataGridView gvAuto;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKleur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPrijs;
        private System.Windows.Forms.TextBox txbKenteken;
        private System.Windows.Forms.Label label4;
    }
}