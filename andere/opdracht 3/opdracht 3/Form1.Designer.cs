namespace opdracht_3
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
            this.txtVNaam = new System.Windows.Forms.TextBox();
            this.txtANaam = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnClick = new System.Windows.Forms.Button();
            this.lbnVNaam = new System.Windows.Forms.Label();
            this.lblANaam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtVNaam
            // 
            this.txtVNaam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtVNaam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVNaam.Location = new System.Drawing.Point(454, 39);
            this.txtVNaam.Multiline = true;
            this.txtVNaam.Name = "txtVNaam";
            this.txtVNaam.Size = new System.Drawing.Size(459, 44);
            this.txtVNaam.TabIndex = 0;
            this.txtVNaam.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtANaam
            // 
            this.txtANaam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtANaam.Location = new System.Drawing.Point(454, 89);
            this.txtANaam.Multiline = true;
            this.txtANaam.Name = "txtANaam";
            this.txtANaam.Size = new System.Drawing.Size(459, 44);
            this.txtANaam.TabIndex = 1;
            this.txtANaam.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Location = new System.Drawing.Point(170, 197);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(577, 47);
            this.lblOutput.TabIndex = 2;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(170, 139);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(577, 41);
            this.btnClick.TabIndex = 3;
            this.btnClick.Text = "Click Me!";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // lbnVNaam
            // 
            this.lbnVNaam.Location = new System.Drawing.Point(208, 55);
            this.lbnVNaam.Name = "lbnVNaam";
            this.lbnVNaam.Size = new System.Drawing.Size(170, 28);
            this.lbnVNaam.TabIndex = 4;
            this.lbnVNaam.Text = "Voer uw voornaam in:";
            // 
            // lblANaam
            // 
            this.lblANaam.Location = new System.Drawing.Point(208, 104);
            this.lblANaam.Name = "lblANaam";
            this.lblANaam.Size = new System.Drawing.Size(170, 23);
            this.lblANaam.TabIndex = 5;
            this.lblANaam.Text = "Voer uw achternaam in:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 253);
            this.Controls.Add(this.lblANaam);
            this.Controls.Add(this.lbnVNaam);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtANaam);
            this.Controls.Add(this.txtVNaam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVNaam;
        private System.Windows.Forms.TextBox txtANaam;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lbnVNaam;
        private System.Windows.Forms.Label lblANaam;
    }
}

