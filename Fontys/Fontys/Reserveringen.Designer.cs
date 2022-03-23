namespace Fontys
{
    partial class frmReserveringen
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
            this.calBeginEindDatum = new System.Windows.Forms.MonthCalendar();
            this.lvAuto = new System.Windows.Forms.ListView();
            this.autoId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.autoMerk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.autoKleur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReserveren = new System.Windows.Forms.Button();
            this.dgvReserveringen = new System.Windows.Forms.DataGridView();
            this.lvKlant = new System.Windows.Forms.ListView();
            this.klantID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KlantVoornaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.klantTussenvoegsel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.klantAchternaam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.klantPostcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.autoKenteken = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserveringen)).BeginInit();
            this.SuspendLayout();
            // 
            // calBeginEindDatum
            // 
            this.calBeginEindDatum.Location = new System.Drawing.Point(18, 18);
            this.calBeginEindDatum.MaxSelectionCount = 30;
            this.calBeginEindDatum.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.calBeginEindDatum.Name = "calBeginEindDatum";
            this.calBeginEindDatum.TabIndex = 0;
            this.calBeginEindDatum.Leave += new System.EventHandler(this.calBeginEindDatum_Leave);
            // 
            // lvAuto
            // 
            this.lvAuto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.autoId,
            this.autoKenteken,
            this.autoMerk,
            this.autoKleur});
            this.lvAuto.Location = new System.Drawing.Point(792, 18);
            this.lvAuto.Name = "lvAuto";
            this.lvAuto.Size = new System.Drawing.Size(325, 207);
            this.lvAuto.TabIndex = 2;
            this.lvAuto.UseCompatibleStateImageBehavior = false;
            this.lvAuto.View = System.Windows.Forms.View.Details;
            // 
            // autoId
            // 
            this.autoId.Text = "ID";
            // 
            // autoMerk
            // 
            this.autoMerk.DisplayIndex = 1;
            this.autoMerk.Text = "Merk";
            // 
            // autoKleur
            // 
            this.autoKleur.DisplayIndex = 2;
            this.autoKleur.Text = "Kleur";
            // 
            // btnReserveren
            // 
            this.btnReserveren.BackColor = System.Drawing.Color.Lime;
            this.btnReserveren.Location = new System.Drawing.Point(872, 231);
            this.btnReserveren.Name = "btnReserveren";
            this.btnReserveren.Size = new System.Drawing.Size(78, 28);
            this.btnReserveren.TabIndex = 3;
            this.btnReserveren.Text = "Sla op";
            this.btnReserveren.UseVisualStyleBackColor = false;
            this.btnReserveren.Click += new System.EventHandler(this.btnReserveren_Click);
            // 
            // dgvReserveringen
            // 
            this.dgvReserveringen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReserveringen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReserveringen.Location = new System.Drawing.Point(22, 271);
            this.dgvReserveringen.Name = "dgvReserveringen";
            this.dgvReserveringen.RowTemplate.Height = 24;
            this.dgvReserveringen.Size = new System.Drawing.Size(1095, 262);
            this.dgvReserveringen.TabIndex = 6;
            this.dgvReserveringen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReserveringen_CellContentClick);
            // 
            // lvKlant
            // 
            this.lvKlant.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.klantID,
            this.KlantVoornaam,
            this.klantTussenvoegsel,
            this.klantAchternaam,
            this.klantPostcode});
            this.lvKlant.Location = new System.Drawing.Point(275, 18);
            this.lvKlant.Name = "lvKlant";
            this.lvKlant.Size = new System.Drawing.Size(480, 207);
            this.lvKlant.TabIndex = 1;
            this.lvKlant.UseCompatibleStateImageBehavior = false;
            this.lvKlant.View = System.Windows.Forms.View.Details;
            // 
            // klantID
            // 
            this.klantID.Text = "ID";
            this.klantID.Width = 27;
            // 
            // KlantVoornaam
            // 
            this.KlantVoornaam.Text = "Voornaam";
            this.KlantVoornaam.Width = 75;
            // 
            // klantTussenvoegsel
            // 
            this.klantTussenvoegsel.Text = "Tussenvoegsel";
            this.klantTussenvoegsel.Width = 107;
            // 
            // klantAchternaam
            // 
            this.klantAchternaam.Text = "Achternaam";
            this.klantAchternaam.Width = 85;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(1040, 231);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 28);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Verwijder";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdate.Location = new System.Drawing.Point(956, 231);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 28);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Pas aan";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // klantPostcode
            // 
            this.klantPostcode.Text = "Postcode";
            // 
            // autoKenteken
            // 
            this.autoKenteken.Text = "Kenteken";
            // 
            // frmReserveringen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 545);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lvKlant);
            this.Controls.Add(this.dgvReserveringen);
            this.Controls.Add(this.btnReserveren);
            this.Controls.Add(this.lvAuto);
            this.Controls.Add(this.calBeginEindDatum);
            this.Name = "frmReserveringen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reserveringen";
            this.Load += new System.EventHandler(this.Reserveringen_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserveringen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calBeginEindDatum;
        private System.Windows.Forms.ListView lvAuto;
        private System.Windows.Forms.Button btnReserveren;
        private System.Windows.Forms.DataGridView dgvReserveringen;
        private System.Windows.Forms.ListView lvKlant;
        private System.Windows.Forms.ColumnHeader klantID;
        private System.Windows.Forms.ColumnHeader KlantVoornaam;
        private System.Windows.Forms.ColumnHeader autoId;
        private System.Windows.Forms.ColumnHeader klantAchternaam;
        private System.Windows.Forms.ColumnHeader autoMerk;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ColumnHeader klantTussenvoegsel;
        private System.Windows.Forms.ColumnHeader autoKleur;
        private System.Windows.Forms.ColumnHeader klantPostcode;
        private System.Windows.Forms.ColumnHeader autoKenteken;
    }
}