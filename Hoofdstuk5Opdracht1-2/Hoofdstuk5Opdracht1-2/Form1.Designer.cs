namespace Hoofdstuk5Opdracht1_2
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
            this.btnOutcome = new System.Windows.Forms.Button();
            this.dateTimePickerGeboorteDatum = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnOutcome
            // 
            this.btnOutcome.Location = new System.Drawing.Point(63, 55);
            this.btnOutcome.Name = "btnOutcome";
            this.btnOutcome.Size = new System.Drawing.Size(102, 43);
            this.btnOutcome.TabIndex = 0;
            this.btnOutcome.Text = "Mag je drinken?";
            this.btnOutcome.UseVisualStyleBackColor = true;
            this.btnOutcome.Click += new System.EventHandler(this.btnOutcome_Click);
            // 
            // dateTimePickerGeboorteDatum
            // 
            this.dateTimePickerGeboorteDatum.Location = new System.Drawing.Point(12, 12);
            this.dateTimePickerGeboorteDatum.Name = "dateTimePickerGeboorteDatum";
            this.dateTimePickerGeboorteDatum.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerGeboorteDatum.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 119);
            this.Controls.Add(this.dateTimePickerGeboorteDatum);
            this.Controls.Add(this.btnOutcome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOutcome;
        private System.Windows.Forms.DateTimePicker dateTimePickerGeboorteDatum;
    }
}

