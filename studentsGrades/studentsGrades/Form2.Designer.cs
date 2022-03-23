namespace studentsGrades
{
    partial class Form2
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
            this.lbStudentGrades = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbStudentGrades
            // 
            this.lbStudentGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentGrades.FormattingEnabled = true;
            this.lbStudentGrades.ItemHeight = 25;
            this.lbStudentGrades.Location = new System.Drawing.Point(13, 14);
            this.lbStudentGrades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbStudentGrades.Name = "lbStudentGrades";
            this.lbStudentGrades.Size = new System.Drawing.Size(248, 504);
            this.lbStudentGrades.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 541);
            this.Controls.Add(this.lbStudentGrades);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbStudentGrades;
    }
}