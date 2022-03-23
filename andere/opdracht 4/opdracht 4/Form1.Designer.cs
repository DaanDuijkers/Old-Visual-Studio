namespace opdracht_4
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
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnKeer = new System.Windows.Forms.Button();
            this.btnDeel = new System.Windows.Forms.Button();
            this.lblUitkomst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(21, 12);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(217, 87);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(308, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(226, 87);
            this.btnMin.TabIndex = 1;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnKeer
            // 
            this.btnKeer.Location = new System.Drawing.Point(598, 12);
            this.btnKeer.Name = "btnKeer";
            this.btnKeer.Size = new System.Drawing.Size(226, 87);
            this.btnKeer.TabIndex = 2;
            this.btnKeer.Text = "*";
            this.btnKeer.UseVisualStyleBackColor = true;
            this.btnKeer.Click += new System.EventHandler(this.btnKeer_Click);
            // 
            // btnDeel
            // 
            this.btnDeel.Location = new System.Drawing.Point(901, 12);
            this.btnDeel.Name = "btnDeel";
            this.btnDeel.Size = new System.Drawing.Size(226, 87);
            this.btnDeel.TabIndex = 3;
            this.btnDeel.Text = "/";
            this.btnDeel.UseVisualStyleBackColor = true;
            this.btnDeel.Click += new System.EventHandler(this.btnDeel_Click);
            // 
            // lblUitkomst
            // 
            this.lblUitkomst.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUitkomst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUitkomst.Location = new System.Drawing.Point(180, 220);
            this.lblUitkomst.Name = "lblUitkomst";
            this.lblUitkomst.Size = new System.Drawing.Size(797, 126);
            this.lblUitkomst.TabIndex = 4;
            this.lblUitkomst.Text = "Uitkomst";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 414);
            this.Controls.Add(this.lblUitkomst);
            this.Controls.Add(this.btnDeel);
            this.Controls.Add(this.btnKeer);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnPlus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnKeer;
        private System.Windows.Forms.Button btnDeel;
        private System.Windows.Forms.Label lblUitkomst;
    }
}

