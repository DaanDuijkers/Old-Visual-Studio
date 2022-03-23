namespace Book2Hoofdstuk1Opdracht1
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
            this.livTelefoons = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // livTelefoons
            // 
            this.livTelefoons.Location = new System.Drawing.Point(25, 253);
            this.livTelefoons.Name = "livTelefoons";
            this.livTelefoons.Size = new System.Drawing.Size(356, 141);
            this.livTelefoons.TabIndex = 0;
            this.livTelefoons.UseCompatibleStateImageBehavior = false;
            this.livTelefoons.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.livTelefoons_DrawSubItem);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 420);
            this.Controls.Add(this.livTelefoons);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView livTelefoons;
    }
}

