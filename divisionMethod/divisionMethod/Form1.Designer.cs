namespace divisionMethod
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
            this.txbNumber1 = new System.Windows.Forms.TextBox();
            this.txbNumber2 = new System.Windows.Forms.TextBox();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.lblDivide = new System.Windows.Forms.Label();
            this.btnEquals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbNumber1
            // 
            this.txbNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumber1.Location = new System.Drawing.Point(12, 12);
            this.txbNumber1.Name = "txbNumber1";
            this.txbNumber1.Size = new System.Drawing.Size(100, 30);
            this.txbNumber1.TabIndex = 0;
            // 
            // txbNumber2
            // 
            this.txbNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumber2.Location = new System.Drawing.Point(142, 12);
            this.txbNumber2.Name = "txbNumber2";
            this.txbNumber2.Size = new System.Drawing.Size(100, 30);
            this.txbNumber2.TabIndex = 1;
            // 
            // txbResult
            // 
            this.txbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbResult.Location = new System.Drawing.Point(286, 12);
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(100, 30);
            this.txbResult.TabIndex = 2;
            // 
            // lblDivide
            // 
            this.lblDivide.AutoSize = true;
            this.lblDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivide.Location = new System.Drawing.Point(118, 14);
            this.lblDivide.Name = "lblDivide";
            this.lblDivide.Size = new System.Drawing.Size(18, 25);
            this.lblDivide.TabIndex = 3;
            this.lblDivide.Text = "/";
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(249, 12);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(31, 30);
            this.btnEquals.TabIndex = 4;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 55);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.lblDivide);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.txbNumber2);
            this.Controls.Add(this.txbNumber1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNumber1;
        private System.Windows.Forms.TextBox txbNumber2;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.Label lblDivide;
        private System.Windows.Forms.Button btnEquals;
    }
}

