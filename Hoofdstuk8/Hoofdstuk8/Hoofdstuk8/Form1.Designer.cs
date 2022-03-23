namespace Hoofdstuk8
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
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnKeer = new System.Windows.Forms.Button();
            this.btnPara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOutput.Location = new System.Drawing.Point(12, 50);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(258, 50);
            this.lblOutput.TabIndex = 0;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(69, 113);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(51, 36);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "+";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(12, 113);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(51, 36);
            this.btnMin.TabIndex = 2;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(126, 113);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(56, 36);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnKeer
            // 
            this.btnKeer.Location = new System.Drawing.Point(188, 113);
            this.btnKeer.Name = "btnKeer";
            this.btnKeer.Size = new System.Drawing.Size(56, 36);
            this.btnKeer.TabIndex = 4;
            this.btnKeer.Text = "X";
            this.btnKeer.UseVisualStyleBackColor = true;
            this.btnKeer.Click += new System.EventHandler(this.btnKeer_Click);
            // 
            // btnPara
            // 
            this.btnPara.Location = new System.Drawing.Point(12, 155);
            this.btnPara.Name = "btnPara";
            this.btnPara.Size = new System.Drawing.Size(108, 42);
            this.btnPara.TabIndex = 5;
            this.btnPara.Text = "+ met parameters";
            this.btnPara.UseVisualStyleBackColor = true;
            this.btnPara.Click += new System.EventHandler(this.btnPara_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 253);
            this.Controls.Add(this.btnPara);
            this.Controls.Add(this.btnKeer);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnKeer;
        private System.Windows.Forms.Button btnPara;
    }
}

