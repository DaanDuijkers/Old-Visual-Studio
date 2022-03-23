namespace carSystem
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
            this.components = new System.ComponentModel.Container();
            this.btnAlarm = new System.Windows.Forms.Button();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblHeadlight = new System.Windows.Forms.Label();
            this.txbTemperature = new System.Windows.Forms.TextBox();
            this.txbHeadlight = new System.Windows.Forms.TextBox();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnAlarm
            // 
            this.btnAlarm.BackColor = System.Drawing.Color.Red;
            this.btnAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarm.Location = new System.Drawing.Point(12, 12);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(113, 41);
            this.btnAlarm.TabIndex = 0;
            this.btnAlarm.Text = "ALARM";
            this.btnAlarm.UseVisualStyleBackColor = false;
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(12, 72);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(124, 25);
            this.lblTemperature.TabIndex = 1;
            this.lblTemperature.Text = "Temperature";
            this.lblTemperature.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblHeadlight
            // 
            this.lblHeadlight.AutoSize = true;
            this.lblHeadlight.Location = new System.Drawing.Point(12, 115);
            this.lblHeadlight.Name = "lblHeadlight";
            this.lblHeadlight.Size = new System.Drawing.Size(94, 25);
            this.lblHeadlight.TabIndex = 2;
            this.lblHeadlight.Text = "Headlight";
            this.lblHeadlight.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txbTemperature
            // 
            this.txbTemperature.Location = new System.Drawing.Point(142, 69);
            this.txbTemperature.Name = "txbTemperature";
            this.txbTemperature.ReadOnly = true;
            this.txbTemperature.Size = new System.Drawing.Size(176, 30);
            this.txbTemperature.TabIndex = 3;
            // 
            // txbHeadlight
            // 
            this.txbHeadlight.Location = new System.Drawing.Point(142, 112);
            this.txbHeadlight.Name = "txbHeadlight";
            this.txbHeadlight.ReadOnly = true;
            this.txbHeadlight.Size = new System.Drawing.Size(176, 30);
            this.txbHeadlight.TabIndex = 4;
            // 
            // lbLog
            // 
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 25;
            this.lbLog.Location = new System.Drawing.Point(347, 56);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(265, 329);
            this.lbLog.TabIndex = 5;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(342, 28);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(45, 25);
            this.lblLog.TabIndex = 6;
            this.lblLog.Text = "Log";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 403);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.txbHeadlight);
            this.Controls.Add(this.txbTemperature);
            this.Controls.Add(this.lblHeadlight);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.btnAlarm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlarm;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblHeadlight;
        private System.Windows.Forms.TextBox txbTemperature;
        private System.Windows.Forms.TextBox txbHeadlight;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Label lblLog;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
    }
}

