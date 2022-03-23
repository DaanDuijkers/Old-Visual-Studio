namespace MockExam
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
            this.btnParkBicycle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnParkBicycle
            // 
            this.btnParkBicycle.Location = new System.Drawing.Point(264, 129);
            this.btnParkBicycle.Name = "btnParkBicycle";
            this.btnParkBicycle.Size = new System.Drawing.Size(133, 40);
            this.btnParkBicycle.TabIndex = 0;
            this.btnParkBicycle.Text = "Park bicycle";
            this.btnParkBicycle.UseVisualStyleBackColor = true;
            this.btnParkBicycle.Click += new System.EventHandler(this.btnParkBicycle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 543);
            this.Controls.Add(this.btnParkBicycle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnParkBicycle;
    }
}

