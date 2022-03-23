namespace Smoothies
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnZoek = new System.Windows.Forms.Button();
            this.btnWisSelectie = new System.Windows.Forms.Button();
            this.btnWisIngrediënt = new System.Windows.Forms.Button();
            this.btnDefaultLijst = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txbIngrediënt = new System.Windows.Forms.TextBox();
            this.livIngrediënten = new System.Windows.Forms.ListView();
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
            this.btnZoek.Location = new System.Drawing.Point(24, 54);
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
            this.btnWisSelectie.Location = new System.Drawing.Point(24, 92);
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
            this.btnWisIngrediënt.Location = new System.Drawing.Point(24, 170);
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
            this.btnDefaultLijst.Location = new System.Drawing.Point(24, 267);
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
            this.btnExit.Location = new System.Drawing.Point(24, 307);
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
            this.livIngrediënten.Location = new System.Drawing.Point(141, 54);
            this.livIngrediënten.Name = "livIngrediënten";
            this.livIngrediënten.Size = new System.Drawing.Size(230, 276);
            this.livIngrediënten.TabIndex = 7;
            this.livIngrediënten.UseCompatibleStateImageBehavior = false;
            this.livIngrediënten.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.livIngrediënten_DrawColumnHeader);
            this.livIngrediënten.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.livIngrediënten_DrawSubItem);
            this.livIngrediënten.Click += new System.EventHandler(this.livIngrediënten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 347);
            this.Controls.Add(this.livIngrediënten);
            this.Controls.Add(this.txbIngrediënt);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDefaultLijst);
            this.Controls.Add(this.btnWisIngrediënt);
            this.Controls.Add(this.btnWisSelectie);
            this.Controls.Add(this.btnZoek);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Smoothies";
            this.Load += new System.EventHandler(this.frmSmoothies_Load);
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
    }
}

