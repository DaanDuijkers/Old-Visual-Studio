namespace lucasNumbers
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
            this.txbInputNumber = new System.Windows.Forms.TextBox();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnTask3 = new System.Windows.Forms.Button();
            this.btnTask2 = new System.Windows.Forms.Button();
            this.btnTask1 = new System.Windows.Forms.Button();
            this.lblInputNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbInputNumber
            // 
            this.txbInputNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbInputNumber.Location = new System.Drawing.Point(258, 55);
            this.txbInputNumber.Name = "txbInputNumber";
            this.txbInputNumber.Size = new System.Drawing.Size(124, 30);
            this.txbInputNumber.TabIndex = 20;
            // 
            // lbOutput
            // 
            this.lbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.ItemHeight = 25;
            this.lbOutput.Location = new System.Drawing.Point(445, 91);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(238, 304);
            this.lbOutput.TabIndex = 19;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(440, 60);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(71, 25);
            this.lblOutput.TabIndex = 18;
            this.lblOutput.Text = "Output";
            // 
            // btnTask3
            // 
            this.btnTask3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTask3.Location = new System.Drawing.Point(122, 172);
            this.btnTask3.Name = "btnTask3";
            this.btnTask3.Size = new System.Drawing.Size(95, 36);
            this.btnTask3.TabIndex = 14;
            this.btnTask3.Text = "Task 3";
            this.btnTask3.UseVisualStyleBackColor = true;
            this.btnTask3.Click += new System.EventHandler(this.btnTask3_Click);
            // 
            // btnTask2
            // 
            this.btnTask2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTask2.Location = new System.Drawing.Point(122, 130);
            this.btnTask2.Name = "btnTask2";
            this.btnTask2.Size = new System.Drawing.Size(95, 36);
            this.btnTask2.TabIndex = 13;
            this.btnTask2.Text = "Task 2";
            this.btnTask2.UseVisualStyleBackColor = true;
            this.btnTask2.Click += new System.EventHandler(this.btnTask2_Click);
            // 
            // btnTask1
            // 
            this.btnTask1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTask1.Location = new System.Drawing.Point(122, 88);
            this.btnTask1.Name = "btnTask1";
            this.btnTask1.Size = new System.Drawing.Size(95, 36);
            this.btnTask1.TabIndex = 12;
            this.btnTask1.Text = "Task 1";
            this.btnTask1.UseVisualStyleBackColor = true;
            this.btnTask1.Click += new System.EventHandler(this.btnTask1_Click);
            // 
            // lblInputNumber
            // 
            this.lblInputNumber.AutoSize = true;
            this.lblInputNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputNumber.Location = new System.Drawing.Point(117, 60);
            this.lblInputNumber.Name = "lblInputNumber";
            this.lblInputNumber.Size = new System.Drawing.Size(135, 25);
            this.lblInputNumber.TabIndex = 11;
            this.lblInputNumber.Text = "Input Number:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbInputNumber);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnTask3);
            this.Controls.Add(this.btnTask2);
            this.Controls.Add(this.btnTask1);
            this.Controls.Add(this.lblInputNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbInputNumber;
        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnTask3;
        private System.Windows.Forms.Button btnTask2;
        private System.Windows.Forms.Button btnTask1;
        private System.Windows.Forms.Label lblInputNumber;
    }
}

