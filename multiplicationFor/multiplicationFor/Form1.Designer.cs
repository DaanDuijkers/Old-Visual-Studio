namespace multiplicationFor
{
    partial class frmMultiplicationTable
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
            this.lblBaseNumber = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txbBaseNumber = new System.Windows.Forms.TextBox();
            this.txbLength = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBaseNumber
            // 
            this.lblBaseNumber.AutoSize = true;
            this.lblBaseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseNumber.Location = new System.Drawing.Point(31, 61);
            this.lblBaseNumber.Name = "lblBaseNumber";
            this.lblBaseNumber.Size = new System.Drawing.Size(134, 25);
            this.lblBaseNumber.TabIndex = 0;
            this.lblBaseNumber.Text = "Base number:";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(31, 119);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(78, 25);
            this.lblLength.TabIndex = 1;
            this.lblLength.Text = "Length:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(36, 209);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 25);
            this.lblResult.TabIndex = 2;
            // 
            // txbBaseNumber
            // 
            this.txbBaseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBaseNumber.Location = new System.Drawing.Point(171, 56);
            this.txbBaseNumber.Name = "txbBaseNumber";
            this.txbBaseNumber.Size = new System.Drawing.Size(100, 30);
            this.txbBaseNumber.TabIndex = 3;
            // 
            // txbLength
            // 
            this.txbLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLength.Location = new System.Drawing.Point(171, 114);
            this.txbLength.Name = "txbLength";
            this.txbLength.Size = new System.Drawing.Size(100, 30);
            this.txbLength.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(299, 56);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(107, 87);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmMultiplicationTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txbLength);
            this.Controls.Add(this.txbBaseNumber);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblBaseNumber);
            this.Name = "frmMultiplicationTable";
            this.Text = "Multiplication table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaseNumber;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txbBaseNumber;
        private System.Windows.Forms.TextBox txbLength;
        private System.Windows.Forms.Button btnCalculate;
    }
}

