
namespace simpleChatApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbMessages = new System.Windows.Forms.ListBox();
            this.txbText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbMessages
            // 
            this.lbMessages.FormattingEnabled = true;
            this.lbMessages.ItemHeight = 20;
            this.lbMessages.Location = new System.Drawing.Point(12, 12);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(776, 224);
            this.lbMessages.TabIndex = 0;
            // 
            // txbText
            // 
            this.txbText.Location = new System.Drawing.Point(12, 243);
            this.txbText.Name = "txbText";
            this.txbText.Size = new System.Drawing.Size(776, 27);
            this.txbText.TabIndex = 1;
            this.txbText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbText_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 282);
            this.Controls.Add(this.txbText);
            this.Controls.Add(this.lbMessages);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMessages;
        private System.Windows.Forms.TextBox txbText;
    }
}

