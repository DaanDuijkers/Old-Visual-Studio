namespace Login
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inloggenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrerenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aanpassenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPagina = new System.Windows.Forms.Panel();
            this.uitloggenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.inloggenToolStripMenuItem,
            this.registrerenToolStripMenuItem,
            this.aanpassenToolStripMenuItem,
            this.uitloggenToolStripMenuItem,
            this.afsluitenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(560, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // inloggenToolStripMenuItem
            // 
            this.inloggenToolStripMenuItem.Name = "inloggenToolStripMenuItem";
            this.inloggenToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.inloggenToolStripMenuItem.Text = "Inloggen";
            this.inloggenToolStripMenuItem.Click += new System.EventHandler(this.inloggenToolStripMenuItem_Click);
            // 
            // registrerenToolStripMenuItem
            // 
            this.registrerenToolStripMenuItem.Name = "registrerenToolStripMenuItem";
            this.registrerenToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.registrerenToolStripMenuItem.Text = "Registreren";
            this.registrerenToolStripMenuItem.Click += new System.EventHandler(this.registrerenToolStripMenuItem_Click);
            // 
            // aanpassenToolStripMenuItem
            // 
            this.aanpassenToolStripMenuItem.Name = "aanpassenToolStripMenuItem";
            this.aanpassenToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.aanpassenToolStripMenuItem.Text = "Aanpassen";
            this.aanpassenToolStripMenuItem.Click += new System.EventHandler(this.aanpassenToolStripMenuItem_Click);
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.afsluitenToolStripMenuItem.Text = "Afsluiten";
            this.afsluitenToolStripMenuItem.Click += new System.EventHandler(this.afsluitenToolStripMenuItem_Click);
            // 
            // pnlPagina
            // 
            this.pnlPagina.Location = new System.Drawing.Point(12, 31);
            this.pnlPagina.Name = "pnlPagina";
            this.pnlPagina.Size = new System.Drawing.Size(536, 411);
            this.pnlPagina.TabIndex = 1;
            // 
            // uitloggenToolStripMenuItem
            // 
            this.uitloggenToolStripMenuItem.Name = "uitloggenToolStripMenuItem";
            this.uitloggenToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.uitloggenToolStripMenuItem.Text = "Uitloggen";
            this.uitloggenToolStripMenuItem.Click += new System.EventHandler(this.uitloggenToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 454);
            this.Controls.Add(this.pnlPagina);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "FormMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inloggenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrerenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aanpassenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem;
        private System.Windows.Forms.Panel pnlPagina;
        private System.Windows.Forms.ToolStripMenuItem uitloggenToolStripMenuItem;
    }
}

