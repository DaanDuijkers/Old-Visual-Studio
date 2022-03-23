
namespace oodWeek2Exercise1
{
    partial class CityForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangeCity = new System.Windows.Forms.Button();
            this.txbCity = new System.Windows.Forms.TextBox();
            this.lbStreets = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "City:";
            // 
            // btnChangeCity
            // 
            this.btnChangeCity.Location = new System.Drawing.Point(647, 12);
            this.btnChangeCity.Name = "btnChangeCity";
            this.btnChangeCity.Size = new System.Drawing.Size(121, 34);
            this.btnChangeCity.TabIndex = 1;
            this.btnChangeCity.Text = "Change City";
            this.btnChangeCity.UseVisualStyleBackColor = true;
            this.btnChangeCity.Click += new System.EventHandler(this.btnChangeCity_Click);
            // 
            // txbCity
            // 
            this.txbCity.Location = new System.Drawing.Point(65, 15);
            this.txbCity.Name = "txbCity";
            this.txbCity.Size = new System.Drawing.Size(576, 28);
            this.txbCity.TabIndex = 2;
            // 
            // lbStreets
            // 
            this.lbStreets.FormattingEnabled = true;
            this.lbStreets.ItemHeight = 22;
            this.lbStreets.Location = new System.Drawing.Point(13, 60);
            this.lbStreets.Name = "lbStreets";
            this.lbStreets.Size = new System.Drawing.Size(751, 466);
            this.lbStreets.TabIndex = 3;
            // 
            // CityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 543);
            this.Controls.Add(this.lbStreets);
            this.Controls.Add(this.txbCity);
            this.Controls.Add(this.btnChangeCity);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CityForm";
            this.Text = "CityForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChangeCity;
        private System.Windows.Forms.TextBox txbCity;
        private System.Windows.Forms.ListBox lbStreets;
    }
}