namespace ArduinoWeek10Assignment
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblAlarm = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblAlarmHistory = new System.Windows.Forms.Label();
            this.lbAlarmHistory = new System.Windows.Forms.ListBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lblTemperature = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // lblAlarm
            // 
            this.lblAlarm.AutoSize = true;
            this.lblAlarm.Location = new System.Drawing.Point(12, 9);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(69, 25);
            this.lblAlarm.TabIndex = 0;
            this.lblAlarm.Text = "Alarm:";
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.LimeGreen;
            this.lblColor.Location = new System.Drawing.Point(87, 9);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(115, 115);
            this.lblColor.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(92, 140);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(153, 38);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblAlarmHistory
            // 
            this.lblAlarmHistory.AutoSize = true;
            this.lblAlarmHistory.Location = new System.Drawing.Point(338, 9);
            this.lblAlarmHistory.Name = "lblAlarmHistory";
            this.lblAlarmHistory.Size = new System.Drawing.Size(128, 25);
            this.lblAlarmHistory.TabIndex = 3;
            this.lblAlarmHistory.Text = "Alarm History";
            // 
            // lbAlarmHistory
            // 
            this.lbAlarmHistory.FormattingEnabled = true;
            this.lbAlarmHistory.ItemHeight = 25;
            this.lbAlarmHistory.Location = new System.Drawing.Point(343, 47);
            this.lbAlarmHistory.Name = "lbAlarmHistory";
            this.lbAlarmHistory.Size = new System.Drawing.Size(408, 404);
            this.lbAlarmHistory.TabIndex = 4;
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(17, 270);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(180, 25);
            this.lblTemperature.TabIndex = 5;
            this.lblTemperature.Text = "Room Temperature";
            // 
            // timer4
            // 
            this.timer4.Interval = 1;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 494);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.lbAlarmHistory);
            this.Controls.Add(this.lblAlarmHistory);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblAlarm);
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

        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblAlarmHistory;
        private System.Windows.Forms.ListBox lbAlarmHistory;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Timer timer4;
    }
}

