namespace Hoofdstuk5Instructie
{
    partial class Datumvoorbeeld
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
            this.btnVandaag = new System.Windows.Forms.Button();
            this.btnJaar = new System.Windows.Forms.Button();
            this.btnNummer = new System.Windows.Forms.Button();
            this.btnWeekdag = new System.Windows.Forms.Button();
            this.btnLeeftijd = new System.Windows.Forms.Button();
            this.btnAfkorting = new System.Windows.Forms.Button();
            this.btnNaam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerGeboorteDatum = new System.Windows.Forms.DateTimePicker();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVandaag
            // 
            this.btnVandaag.Location = new System.Drawing.Point(12, 12);
            this.btnVandaag.Name = "btnVandaag";
            this.btnVandaag.Size = new System.Drawing.Size(101, 31);
            this.btnVandaag.TabIndex = 0;
            this.btnVandaag.Text = "Vandaag";
            this.btnVandaag.UseVisualStyleBackColor = true;
            this.btnVandaag.Click += new System.EventHandler(this.btnVandaag_Click);
            // 
            // btnJaar
            // 
            this.btnJaar.Location = new System.Drawing.Point(12, 49);
            this.btnJaar.Name = "btnJaar";
            this.btnJaar.Size = new System.Drawing.Size(101, 31);
            this.btnJaar.TabIndex = 1;
            this.btnJaar.Text = "Jaar";
            this.btnJaar.UseVisualStyleBackColor = true;
            this.btnJaar.Click += new System.EventHandler(this.btnJaar_Click);
            // 
            // btnNummer
            // 
            this.btnNummer.Location = new System.Drawing.Point(119, 49);
            this.btnNummer.Name = "btnNummer";
            this.btnNummer.Size = new System.Drawing.Size(101, 31);
            this.btnNummer.TabIndex = 2;
            this.btnNummer.Text = "Nummer";
            this.btnNummer.UseVisualStyleBackColor = true;
            this.btnNummer.Click += new System.EventHandler(this.btnNummer_Click);
            // 
            // btnWeekdag
            // 
            this.btnWeekdag.Location = new System.Drawing.Point(226, 49);
            this.btnWeekdag.Name = "btnWeekdag";
            this.btnWeekdag.Size = new System.Drawing.Size(101, 31);
            this.btnWeekdag.TabIndex = 3;
            this.btnWeekdag.Text = "Weekdag";
            this.btnWeekdag.UseVisualStyleBackColor = true;
            this.btnWeekdag.Click += new System.EventHandler(this.btnWeekdag_Click);
            // 
            // btnLeeftijd
            // 
            this.btnLeeftijd.Location = new System.Drawing.Point(12, 185);
            this.btnLeeftijd.Name = "btnLeeftijd";
            this.btnLeeftijd.Size = new System.Drawing.Size(101, 31);
            this.btnLeeftijd.TabIndex = 4;
            this.btnLeeftijd.Text = "Leeftijd";
            this.btnLeeftijd.UseVisualStyleBackColor = true;
            this.btnLeeftijd.Click += new System.EventHandler(this.btnLeeftijd_Click);
            // 
            // btnAfkorting
            // 
            this.btnAfkorting.Location = new System.Drawing.Point(119, 123);
            this.btnAfkorting.Name = "btnAfkorting";
            this.btnAfkorting.Size = new System.Drawing.Size(101, 31);
            this.btnAfkorting.TabIndex = 5;
            this.btnAfkorting.Text = "Afkorting";
            this.btnAfkorting.UseVisualStyleBackColor = true;
            this.btnAfkorting.Click += new System.EventHandler(this.btnAfkorting_Click);
            // 
            // btnNaam
            // 
            this.btnNaam.Location = new System.Drawing.Point(119, 86);
            this.btnNaam.Name = "btnNaam";
            this.btnNaam.Size = new System.Drawing.Size(101, 31);
            this.btnNaam.TabIndex = 6;
            this.btnNaam.Text = "Naam";
            this.btnNaam.UseVisualStyleBackColor = true;
            this.btnNaam.Click += new System.EventHandler(this.btnNaam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Geboren op:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(146, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Maand";
            // 
            // dateTimePickerGeboorteDatum
            // 
            this.dateTimePickerGeboorteDatum.Location = new System.Drawing.Point(106, 160);
            this.dateTimePickerGeboorteDatum.Name = "dateTimePickerGeboorteDatum";
            this.dateTimePickerGeboorteDatum.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerGeboorteDatum.TabIndex = 9;
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblOutput.Location = new System.Drawing.Point(12, 219);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(316, 149);
            this.lblOutput.TabIndex = 10;
            // 
            // Datumvoorbeeld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 380);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.dateTimePickerGeboorteDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNaam);
            this.Controls.Add(this.btnAfkorting);
            this.Controls.Add(this.btnLeeftijd);
            this.Controls.Add(this.btnWeekdag);
            this.Controls.Add(this.btnNummer);
            this.Controls.Add(this.btnJaar);
            this.Controls.Add(this.btnVandaag);
            this.Name = "Datumvoorbeeld";
            this.Text = "Datumvoorbeeld";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVandaag;
        private System.Windows.Forms.Button btnJaar;
        private System.Windows.Forms.Button btnNummer;
        private System.Windows.Forms.Button btnWeekdag;
        private System.Windows.Forms.Button btnLeeftijd;
        private System.Windows.Forms.Button btnAfkorting;
        private System.Windows.Forms.Button btnNaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerGeboorteDatum;
        private System.Windows.Forms.Label lblOutput;
    }
}

