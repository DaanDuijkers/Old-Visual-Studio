namespace Smoothies
{
    partial class frmSmoothiesPlus
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
            this.btnZoek = new System.Windows.Forms.Button();
            this.btnWisSelectie = new System.Windows.Forms.Button();
            this.btnWisIngrediënt = new System.Windows.Forms.Button();
            this.btnDefaultLijst = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txbIngrediënt = new System.Windows.Forms.TextBox();
            this.livIngrediënten = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKleurIngrediënt = new System.Windows.Forms.Button();
            this.txbLandVanHerkomst = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbCalorieën = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbPrijsPerKilo = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrediënt:";
            // 
            // btnZoek
            // 
            this.btnZoek.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnZoek.Location = new System.Drawing.Point(24, 134);
            this.btnZoek.Name = "btnZoek";
            this.btnZoek.Size = new System.Drawing.Size(99, 32);
            this.btnZoek.TabIndex = 1;
            this.btnZoek.Text = "Zoek in lijst";
            this.btnZoek.UseVisualStyleBackColor = false;
            this.btnZoek.Click += new System.EventHandler(this.btnZoek_Click);
            // 
            // btnWisSelectie
            // 
            this.btnWisSelectie.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnWisSelectie.Location = new System.Drawing.Point(24, 177);
            this.btnWisSelectie.Name = "btnWisSelectie";
            this.btnWisSelectie.Size = new System.Drawing.Size(99, 60);
            this.btnWisSelectie.TabIndex = 2;
            this.btnWisSelectie.Text = "Selectie \r\nongedaan \r\nmaken";
            this.btnWisSelectie.UseVisualStyleBackColor = false;
            this.btnWisSelectie.Click += new System.EventHandler(this.btnWisSelectie_Click);
            // 
            // btnWisIngrediënt
            // 
            this.btnWisIngrediënt.BackColor = System.Drawing.Color.LightCoral;
            this.btnWisIngrediënt.Location = new System.Drawing.Point(24, 253);
            this.btnWisIngrediënt.Name = "btnWisIngrediënt";
            this.btnWisIngrediënt.Size = new System.Drawing.Size(99, 79);
            this.btnWisIngrediënt.TabIndex = 3;
            this.btnWisIngrediënt.Text = "Wis ingrediënt";
            this.btnWisIngrediënt.UseVisualStyleBackColor = false;
            this.btnWisIngrediënt.Click += new System.EventHandler(this.btnWisIngrediënt_Click);
            // 
            // btnDefaultLijst
            // 
            this.btnDefaultLijst.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDefaultLijst.Location = new System.Drawing.Point(24, 349);
            this.btnDefaultLijst.Name = "btnDefaultLijst";
            this.btnDefaultLijst.Size = new System.Drawing.Size(99, 23);
            this.btnDefaultLijst.TabIndex = 4;
            this.btnDefaultLijst.Text = "Default lijst";
            this.btnDefaultLijst.UseVisualStyleBackColor = false;
            this.btnDefaultLijst.Click += new System.EventHandler(this.btnDefaultLijst_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.Location = new System.Drawing.Point(24, 387);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Einde";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txbIngrediënt
            // 
            this.txbIngrediënt.Location = new System.Drawing.Point(141, 16);
            this.txbIngrediënt.Name = "txbIngrediënt";
            this.txbIngrediënt.Size = new System.Drawing.Size(230, 22);
            this.txbIngrediënt.TabIndex = 6;
            this.txbIngrediënt.TextChanged += new System.EventHandler(this.txbIngrediënt_TextChanged);
            // 
            // livIngrediënten
            // 
            this.livIngrediënten.HideSelection = false;
            this.livIngrediënten.Location = new System.Drawing.Point(141, 134);
            this.livIngrediënten.Name = "livIngrediënten";
            this.livIngrediënten.Size = new System.Drawing.Size(626, 276);
            this.livIngrediënten.TabIndex = 7;
            this.livIngrediënten.UseCompatibleStateImageBehavior = false;
            this.livIngrediënten.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.livIngrediënten_DrawColumnHeader);
            this.livIngrediënten.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.livIngrediënten_DrawSubItem);
            this.livIngrediënten.Click += new System.EventHandler(this.livIngrediënten_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Land van herkomst:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kleur:";
            // 
            // btnKleurIngrediënt
            // 
            this.btnKleurIngrediënt.Location = new System.Drawing.Point(192, 52);
            this.btnKleurIngrediënt.Name = "btnKleurIngrediënt";
            this.btnKleurIngrediënt.Size = new System.Drawing.Size(118, 23);
            this.btnKleurIngrediënt.TabIndex = 10;
            this.btnKleurIngrediënt.UseVisualStyleBackColor = true;
            this.btnKleurIngrediënt.TextChanged += new System.EventHandler(this.btnKleurIngrediënt_TextChanged);
            this.btnKleurIngrediënt.Click += new System.EventHandler(this.btnKleurIngrediënt_Click);
            // 
            // txbLandVanHerkomst
            // 
            this.txbLandVanHerkomst.Location = new System.Drawing.Point(531, 15);
            this.txbLandVanHerkomst.Name = "txbLandVanHerkomst";
            this.txbLandVanHerkomst.Size = new System.Drawing.Size(236, 22);
            this.txbLandVanHerkomst.TabIndex = 11;
            this.txbLandVanHerkomst.TextChanged += new System.EventHandler(this.txbLandVanHerkomst_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Aantal colorieën:";
            // 
            // txbCalorieën
            // 
            this.txbCalorieën.Location = new System.Drawing.Point(447, 52);
            this.txbCalorieën.Name = "txbCalorieën";
            this.txbCalorieën.Size = new System.Drawing.Size(77, 22);
            this.txbCalorieën.TabIndex = 13;
            this.txbCalorieën.TextChanged += new System.EventHandler(this.txbCalorieën_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Prijs per kilo:";
            // 
            // txbPrijsPerKilo
            // 
            this.txbPrijsPerKilo.Location = new System.Drawing.Point(625, 53);
            this.txbPrijsPerKilo.Name = "txbPrijsPerKilo";
            this.txbPrijsPerKilo.Size = new System.Drawing.Size(142, 22);
            this.txbPrijsPerKilo.TabIndex = 15;
            this.txbPrijsPerKilo.TextChanged += new System.EventHandler(this.txbPrijsPerKilo_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmSmoothiesPlus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 422);
            this.Controls.Add(this.txbPrijsPerKilo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbCalorieën);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbLandVanHerkomst);
            this.Controls.Add(this.btnKleurIngrediënt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.livIngrediënten);
            this.Controls.Add(this.txbIngrediënt);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDefaultLijst);
            this.Controls.Add(this.btnWisIngrediënt);
            this.Controls.Add(this.btnWisSelectie);
            this.Controls.Add(this.btnZoek);
            this.Controls.Add(this.label1);
            this.Name = "frmSmoothiesPlus";
            this.Text = "SmoothiesPlus";
            this.Load += new System.EventHandler(this.frmSmoothies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZoek;
        private System.Windows.Forms.Button btnWisSelectie;
        private System.Windows.Forms.Button btnWisIngrediënt;
        private System.Windows.Forms.Button btnDefaultLijst;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txbIngrediënt;
        private System.Windows.Forms.ListView livIngrediënten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKleurIngrediënt;
        private System.Windows.Forms.TextBox txbLandVanHerkomst;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbCalorieën;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbPrijsPerKilo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

