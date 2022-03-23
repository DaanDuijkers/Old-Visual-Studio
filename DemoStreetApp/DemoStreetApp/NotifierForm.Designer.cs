namespace DemoStreetApp
{
    partial class NotifierForm
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
            this.lblStreetInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStreetInfo
            // 
            this.lblStreetInfo.AutoSize = true;
            this.lblStreetInfo.Location = new System.Drawing.Point(270, 171);
            this.lblStreetInfo.Name = "lblStreetInfo";
            this.lblStreetInfo.Size = new System.Drawing.Size(0, 24);
            this.lblStreetInfo.TabIndex = 0;
            // 
            // NotifierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 539);
            this.Controls.Add(this.lblStreetInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NotifierForm";
            this.Text = "NotifierForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStreetInfo;
    }
}