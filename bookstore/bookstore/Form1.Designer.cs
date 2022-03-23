namespace bookstore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtPaginaLinks = new System.Windows.Forms.TextBox();
            this.txtPaginaRechts = new System.Windows.Forms.TextBox();
            this.btnVorige = new System.Windows.Forms.Button();
            this.btnVeelPaginasTerug = new System.Windows.Forms.Button();
            this.btnVeelPaginasVooruit = new System.Windows.Forms.Button();
            this.btnVolgende = new System.Windows.Forms.Button();
            this.txtAantalPaginasTerug = new System.Windows.Forms.TextBox();
            this.txtAantalPaginasVooruit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblActiefBoek = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(279, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 148);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(421, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 148);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(553, 15);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 148);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // txtPaginaLinks
            // 
            this.txtPaginaLinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaginaLinks.Location = new System.Drawing.Point(279, 181);
            this.txtPaginaLinks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPaginaLinks.Multiline = true;
            this.txtPaginaLinks.Name = "txtPaginaLinks";
            this.txtPaginaLinks.Size = new System.Drawing.Size(301, 358);
            this.txtPaginaLinks.TabIndex = 3;
            this.txtPaginaLinks.Text = "1";
            // 
            // txtPaginaRechts
            // 
            this.txtPaginaRechts.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaginaRechts.Location = new System.Drawing.Point(583, 181);
            this.txtPaginaRechts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPaginaRechts.Multiline = true;
            this.txtPaginaRechts.Name = "txtPaginaRechts";
            this.txtPaginaRechts.Size = new System.Drawing.Size(301, 358);
            this.txtPaginaRechts.TabIndex = 4;
            this.txtPaginaRechts.Text = "2";
            // 
            // btnVorige
            // 
            this.btnVorige.Location = new System.Drawing.Point(279, 571);
            this.btnVorige.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVorige.Name = "btnVorige";
            this.btnVorige.Size = new System.Drawing.Size(113, 61);
            this.btnVorige.TabIndex = 5;
            this.btnVorige.Text = "Vorige";
            this.btnVorige.UseVisualStyleBackColor = true;
            // 
            // btnVeelPaginasTerug
            // 
            this.btnVeelPaginasTerug.Location = new System.Drawing.Point(449, 571);
            this.btnVeelPaginasTerug.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVeelPaginasTerug.Name = "btnVeelPaginasTerug";
            this.btnVeelPaginasTerug.Size = new System.Drawing.Size(114, 61);
            this.btnVeelPaginasTerug.TabIndex = 6;
            this.btnVeelPaginasTerug.Text = "<<<";
            this.btnVeelPaginasTerug.UseVisualStyleBackColor = true;
            // 
            // btnVeelPaginasVooruit
            // 
            this.btnVeelPaginasVooruit.Location = new System.Drawing.Point(610, 571);
            this.btnVeelPaginasVooruit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVeelPaginasVooruit.Name = "btnVeelPaginasVooruit";
            this.btnVeelPaginasVooruit.Size = new System.Drawing.Size(117, 61);
            this.btnVeelPaginasVooruit.TabIndex = 7;
            this.btnVeelPaginasVooruit.Text = ">>>";
            this.btnVeelPaginasVooruit.UseVisualStyleBackColor = true;
            // 
            // btnVolgende
            // 
            this.btnVolgende.Location = new System.Drawing.Point(764, 571);
            this.btnVolgende.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolgende.Name = "btnVolgende";
            this.btnVolgende.Size = new System.Drawing.Size(119, 61);
            this.btnVolgende.TabIndex = 8;
            this.btnVolgende.Text = "Volgende";
            this.btnVolgende.UseVisualStyleBackColor = true;
            // 
            // txtAantalPaginasTerug
            // 
            this.txtAantalPaginasTerug.Location = new System.Drawing.Point(449, 646);
            this.txtAantalPaginasTerug.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAantalPaginasTerug.Name = "txtAantalPaginasTerug";
            this.txtAantalPaginasTerug.Size = new System.Drawing.Size(68, 22);
            this.txtAantalPaginasTerug.TabIndex = 9;
            // 
            // txtAantalPaginasVooruit
            // 
            this.txtAantalPaginasVooruit.Location = new System.Drawing.Point(659, 646);
            this.txtAantalPaginasVooruit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAantalPaginasVooruit.Name = "txtAantalPaginasVooruit";
            this.txtAantalPaginasVooruit.Size = new System.Drawing.Size(68, 22);
            this.txtAantalPaginasVooruit.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(964, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Actief boek is: ";
            // 
            // lblActiefBoek
            // 
            this.lblActiefBoek.AutoSize = true;
            this.lblActiefBoek.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiefBoek.Location = new System.Drawing.Point(968, 246);
            this.lblActiefBoek.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActiefBoek.Name = "lblActiefBoek";
            this.lblActiefBoek.Size = new System.Drawing.Size(167, 29);
            this.lblActiefBoek.TabIndex = 12;
            this.lblActiefBoek.Text = "lblActiefBoek";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 675);
            this.Controls.Add(this.lblActiefBoek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAantalPaginasVooruit);
            this.Controls.Add(this.txtAantalPaginasTerug);
            this.Controls.Add(this.btnVolgende);
            this.Controls.Add(this.btnVeelPaginasVooruit);
            this.Controls.Add(this.btnVeelPaginasTerug);
            this.Controls.Add(this.btnVorige);
            this.Controls.Add(this.txtPaginaRechts);
            this.Controls.Add(this.txtPaginaLinks);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtPaginaLinks;
        private System.Windows.Forms.TextBox txtPaginaRechts;
        private System.Windows.Forms.Button btnVorige;
        private System.Windows.Forms.Button btnVeelPaginasTerug;
        private System.Windows.Forms.Button btnVeelPaginasVooruit;
        private System.Windows.Forms.Button btnVolgende;
        private System.Windows.Forms.TextBox txtAantalPaginasTerug;
        private System.Windows.Forms.TextBox txtAantalPaginasVooruit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblActiefBoek;
    }
}

