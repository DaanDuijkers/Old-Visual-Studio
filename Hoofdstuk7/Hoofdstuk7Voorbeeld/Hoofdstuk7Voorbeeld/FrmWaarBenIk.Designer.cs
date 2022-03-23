namespace Hoofdstuk7Voorbeeld
{
    partial class FrmWaarBenIk
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
            this.pnlLocation = new System.Windows.Forms.Panel();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.pnlLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLocation
            // 
            this.pnlLocation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlLocation.Controls.Add(this.lblY);
            this.pnlLocation.Controls.Add(this.lblX);
            this.pnlLocation.Location = new System.Drawing.Point(91, 91);
            this.pnlLocation.Name = "pnlLocation";
            this.pnlLocation.Size = new System.Drawing.Size(105, 44);
            this.pnlLocation.TabIndex = 0;
            // 
            // lblY
            // 
            this.lblY.Location = new System.Drawing.Point(0, 23);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(105, 21);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "0";
            // 
            // lblX
            // 
            this.lblX.Location = new System.Drawing.Point(0, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(105, 23);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "0";
            // 
            // FrmWaarBenIk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.pnlLocation);
            this.Name = "FrmWaarBenIk";
            this.Text = "Waar ben ik";
            this.Load += new System.EventHandler(this.FrmWaarBenIk_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FrmWaarBenIk_MouseClick);
            this.pnlLocation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLocation;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
    }
}

