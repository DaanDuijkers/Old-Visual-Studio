namespace Login
{
    partial class frmHome
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
            this.lblWelkom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelkom
            // 
            this.lblWelkom.AutoSize = true;
            this.lblWelkom.Location = new System.Drawing.Point(185, 168);
            this.lblWelkom.Name = "lblWelkom";
            this.lblWelkom.Size = new System.Drawing.Size(62, 17);
            this.lblWelkom.TabIndex = 0;
            this.lblWelkom.Text = "Welkom:";
            this.lblWelkom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 376);
            this.Controls.Add(this.lblWelkom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.Text = "Home";
            //this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelkom;
    }
}