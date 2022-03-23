namespace Hoofdstuk5Opdracht3
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
            this.dateTimePickerGeboortedatum = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerRijbewijs = new System.Windows.Forms.DateTimePicker();
            this.lblGeboortedatum = new System.Windows.Forms.Label();
            this.txbRijbewijs = new System.Windows.Forms.TextBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerstuur = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePickerGeboortedatum
            // 
            this.dateTimePickerGeboortedatum.Location = new System.Drawing.Point(325, 32);
            this.dateTimePickerGeboortedatum.Name = "dateTimePickerGeboortedatum";
            this.dateTimePickerGeboortedatum.Size = new System.Drawing.Size(234, 22);
            this.dateTimePickerGeboortedatum.TabIndex = 0;
            // 
            // dateTimePickerRijbewijs
            // 
            this.dateTimePickerRijbewijs.Location = new System.Drawing.Point(325, 147);
            this.dateTimePickerRijbewijs.Name = "dateTimePickerRijbewijs";
            this.dateTimePickerRijbewijs.Size = new System.Drawing.Size(234, 22);
            this.dateTimePickerRijbewijs.TabIndex = 1;
            // 
            // lblGeboortedatum
            // 
            this.lblGeboortedatum.AutoSize = true;
            this.lblGeboortedatum.Location = new System.Drawing.Point(12, 37);
            this.lblGeboortedatum.Name = "lblGeboortedatum";
            this.lblGeboortedatum.Size = new System.Drawing.Size(111, 17);
            this.lblGeboortedatum.TabIndex = 3;
            this.lblGeboortedatum.Text = "Geboortedatum:";
            // 
            // txbRijbewijs
            // 
            this.txbRijbewijs.Location = new System.Drawing.Point(325, 88);
            this.txbRijbewijs.Name = "txbRijbewijs";
            this.txbRijbewijs.Size = new System.Drawing.Size(234, 22);
            this.txbRijbewijs.TabIndex = 4;
            // 
            // lblDatum
            // 
            this.lblDatum.Location = new System.Drawing.Point(12, 152);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(288, 41);
            this.lblDatum.TabIndex = 5;
            this.lblDatum.Text = "Datum waarop je het rijbewijs hebt gehaalt (gebruik default als u er geen hebt):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rijbewijs (A1, A2, A3, geen):";
            // 
            // btnVerstuur
            // 
            this.btnVerstuur.Location = new System.Drawing.Point(237, 196);
            this.btnVerstuur.Name = "btnVerstuur";
            this.btnVerstuur.Size = new System.Drawing.Size(103, 45);
            this.btnVerstuur.TabIndex = 7;
            this.btnVerstuur.Text = "Verstuur";
            this.btnVerstuur.UseVisualStyleBackColor = true;
            this.btnVerstuur.Click += new System.EventHandler(this.btnVerstuur_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblOutput.Location = new System.Drawing.Point(12, 261);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(564, 233);
            this.lblOutput.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 503);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnVerstuur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.txbRijbewijs);
            this.Controls.Add(this.lblGeboortedatum);
            this.Controls.Add(this.dateTimePickerRijbewijs);
            this.Controls.Add(this.dateTimePickerGeboortedatum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerGeboortedatum;
        private System.Windows.Forms.DateTimePicker dateTimePickerRijbewijs;
        private System.Windows.Forms.Label lblGeboortedatum;
        private System.Windows.Forms.TextBox txbRijbewijs;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerstuur;
        private System.Windows.Forms.Label lblOutput;
    }
}

