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
            this.dateTimePickerGeboorteDatum = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerRijbewijs = new System.Windows.Forms.DateTimePicker();
            this.radioButtonA1 = new System.Windows.Forms.RadioButton();
            this.radioButtonA2 = new System.Windows.Forms.RadioButton();
            this.radioButtonA3 = new System.Windows.Forms.RadioButton();
            this.radioButtonGeen = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerGeboorteDatum
            // 
            this.dateTimePickerGeboorteDatum.Location = new System.Drawing.Point(372, 37);
            this.dateTimePickerGeboorteDatum.Name = "dateTimePickerGeboorteDatum";
            this.dateTimePickerGeboorteDatum.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerGeboorteDatum.TabIndex = 0;
            // 
            // dateTimePickerRijbewijs
            // 
            this.dateTimePickerRijbewijs.Location = new System.Drawing.Point(372, 165);
            this.dateTimePickerRijbewijs.Name = "dateTimePickerRijbewijs";
            this.dateTimePickerRijbewijs.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerRijbewijs.TabIndex = 1;
            // 
            // radioButtonA1
            // 
            this.radioButtonA1.AutoSize = true;
            this.radioButtonA1.Location = new System.Drawing.Point(372, 92);
            this.radioButtonA1.Name = "radioButtonA1";
            this.radioButtonA1.Size = new System.Drawing.Size(46, 21);
            this.radioButtonA1.TabIndex = 2;
            this.radioButtonA1.TabStop = true;
            this.radioButtonA1.Text = "A1";
            this.radioButtonA1.UseVisualStyleBackColor = true;
            // 
            // radioButtonA2
            // 
            this.radioButtonA2.AutoSize = true;
            this.radioButtonA2.Location = new System.Drawing.Point(431, 92);
            this.radioButtonA2.Name = "radioButtonA2";
            this.radioButtonA2.Size = new System.Drawing.Size(46, 21);
            this.radioButtonA2.TabIndex = 3;
            this.radioButtonA2.TabStop = true;
            this.radioButtonA2.Text = "A2";
            this.radioButtonA2.UseVisualStyleBackColor = true;
            // 
            // radioButtonA3
            // 
            this.radioButtonA3.AutoSize = true;
            this.radioButtonA3.Location = new System.Drawing.Point(483, 92);
            this.radioButtonA3.Name = "radioButtonA3";
            this.radioButtonA3.Size = new System.Drawing.Size(46, 21);
            this.radioButtonA3.TabIndex = 4;
            this.radioButtonA3.TabStop = true;
            this.radioButtonA3.Text = "A3";
            this.radioButtonA3.UseVisualStyleBackColor = true;
            // 
            // radioButtonGeen
            // 
            this.radioButtonGeen.AutoSize = true;
            this.radioButtonGeen.Location = new System.Drawing.Point(535, 94);
            this.radioButtonGeen.Name = "radioButtonGeen";
            this.radioButtonGeen.Size = new System.Drawing.Size(64, 21);
            this.radioButtonGeen.TabIndex = 5;
            this.radioButtonGeen.TabStop = true;
            this.radioButtonGeen.Text = "Geen";
            this.radioButtonGeen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Geboortedatum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rijbewijs dat u al heeft:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "Datum waarop u uw rijbewijs heeft behaald (default als u er geen heeft):";
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(244, 217);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(117, 48);
            this.btnClick.TabIndex = 9;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 322);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonGeen);
            this.Controls.Add(this.radioButtonA3);
            this.Controls.Add(this.radioButtonA2);
            this.Controls.Add(this.radioButtonA1);
            this.Controls.Add(this.dateTimePickerRijbewijs);
            this.Controls.Add(this.dateTimePickerGeboorteDatum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerGeboorteDatum;
        private System.Windows.Forms.DateTimePicker dateTimePickerRijbewijs;
        private System.Windows.Forms.RadioButton radioButtonA1;
        private System.Windows.Forms.RadioButton radioButtonA2;
        private System.Windows.Forms.RadioButton radioButtonA3;
        private System.Windows.Forms.RadioButton radioButtonGeen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClick;
    }
}

