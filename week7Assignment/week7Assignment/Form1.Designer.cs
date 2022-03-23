namespace week7Assignment
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
            this.lbArray = new System.Windows.Forms.ListBox();
            this.btn005 = new System.Windows.Forms.Button();
            this.btn010 = new System.Windows.Forms.Button();
            this.btn050 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn200 = new System.Windows.Forms.Button();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.btn020 = new System.Windows.Forms.Button();
            this.txbAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbArray
            // 
            this.lbArray.FormattingEnabled = true;
            this.lbArray.ItemHeight = 25;
            this.lbArray.Items.AddRange(new object[] {
            "€0.05\t0 \t€0.00",
            "€0.10\t0 \t€0.00",
            "€0.20\t0\t€0.00",
            "€0.50\t0\t€0.00",
            "€1.00\t0\t€0.00",
            "€2.00\t0\t€0.00"});
            this.lbArray.Location = new System.Drawing.Point(119, 37);
            this.lbArray.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbArray.Name = "lbArray";
            this.lbArray.Size = new System.Drawing.Size(256, 254);
            this.lbArray.TabIndex = 0;
            // 
            // btn005
            // 
            this.btn005.Location = new System.Drawing.Point(13, 303);
            this.btn005.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn005.Name = "btn005";
            this.btn005.Size = new System.Drawing.Size(75, 36);
            this.btn005.TabIndex = 1;
            this.btn005.Text = "€ 0.05";
            this.btn005.UseVisualStyleBackColor = true;
            this.btn005.Click += new System.EventHandler(this.btn005_Click);
            // 
            // btn010
            // 
            this.btn010.Location = new System.Drawing.Point(95, 303);
            this.btn010.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn010.Name = "btn010";
            this.btn010.Size = new System.Drawing.Size(75, 36);
            this.btn010.TabIndex = 2;
            this.btn010.Text = "€ 0.10";
            this.btn010.UseVisualStyleBackColor = true;
            this.btn010.Click += new System.EventHandler(this.btn010_Click);
            // 
            // btn050
            // 
            this.btn050.Location = new System.Drawing.Point(258, 303);
            this.btn050.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn050.Name = "btn050";
            this.btn050.Size = new System.Drawing.Size(74, 36);
            this.btn050.TabIndex = 3;
            this.btn050.Text = "€ 0.50";
            this.btn050.UseVisualStyleBackColor = true;
            this.btn050.Click += new System.EventHandler(this.btn050_Click);
            // 
            // btn100
            // 
            this.btn100.Location = new System.Drawing.Point(340, 303);
            this.btn100.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(75, 36);
            this.btn100.TabIndex = 4;
            this.btn100.Text = "€ 1.00";
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Click += new System.EventHandler(this.btn100_Click);
            // 
            // btn200
            // 
            this.btn200.Location = new System.Drawing.Point(423, 303);
            this.btn200.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(74, 36);
            this.btn200.TabIndex = 5;
            this.btn200.Text = "€ 2.00";
            this.btn200.UseVisualStyleBackColor = true;
            this.btn200.Click += new System.EventHandler(this.btn200_Click);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(114, 7);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(63, 25);
            this.lblValue.TabIndex = 6;
            this.lblValue.Text = "Value";
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Location = new System.Drawing.Point(208, 7);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(105, 25);
            this.lblFrequency.TabIndex = 7;
            this.lblFrequency.Text = "Frequency";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(319, 7);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 25);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(381, 7);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(62, 25);
            this.lblSum.TabIndex = 9;
            this.lblSum.Text = "Total:";
            // 
            // txbTotal
            // 
            this.txbTotal.Location = new System.Drawing.Point(382, 37);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.ReadOnly = true;
            this.txbTotal.Size = new System.Drawing.Size(221, 30);
            this.txbTotal.TabIndex = 10;
            this.txbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn020
            // 
            this.btn020.Location = new System.Drawing.Point(177, 303);
            this.btn020.Name = "btn020";
            this.btn020.Size = new System.Drawing.Size(74, 36);
            this.btn020.TabIndex = 11;
            this.btn020.Text = "€ 0.20";
            this.btn020.UseVisualStyleBackColor = true;
            this.btn020.Click += new System.EventHandler(this.btn020_Click);
            // 
            // txbAmount
            // 
            this.txbAmount.Location = new System.Drawing.Point(12, 37);
            this.txbAmount.Name = "txbAmount";
            this.txbAmount.Size = new System.Drawing.Size(100, 30);
            this.txbAmount.TabIndex = 12;
            this.txbAmount.Text = "1";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(12, 7);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(80, 25);
            this.lblAmount.TabIndex = 13;
            this.lblAmount.Text = "Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 348);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txbAmount);
            this.Controls.Add(this.btn020);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFrequency);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.btn200);
            this.Controls.Add(this.btn100);
            this.Controls.Add(this.btn050);
            this.Controls.Add(this.btn010);
            this.Controls.Add(this.btn005);
            this.Controls.Add(this.lbArray);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbArray;
        private System.Windows.Forms.Button btn005;
        private System.Windows.Forms.Button btn010;
        private System.Windows.Forms.Button btn050;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn200;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.Button btn020;
        private System.Windows.Forms.TextBox txbAmount;
        private System.Windows.Forms.Label lblAmount;
    }
}

