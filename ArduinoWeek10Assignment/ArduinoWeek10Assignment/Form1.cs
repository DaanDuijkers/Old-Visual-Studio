using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoWeek10Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // starts up the serial port and timers
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
            timer2.Start();
            timer2.Enabled = true;
            timer3.Start();
            timer3.Enabled = true;
            timer4.Start();
            timer4.Enabled = true;
            serialPort1.Open();
        }

        // serial port closes with the application
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
        }

        // click the button to turn off the alarm if triggered
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (lblColor.BackColor == Color.Red)
            {
                serialPort1.WriteLine("reset");
                lblColor.BackColor = Color.LimeGreen;
                lbAlarmHistory.Items.Add(DateTime.Now.ToString("HH:mm") + " Alarm reset");
                timer2.Start();
            }
        }

        // first timer gives current time to the arduino every second
        private void timer1_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("HHmm");
            serialPort1.WriteLine("time");
            serialPort1.WriteLine(time);
            timer1.Start();
        }

        // second timer activates alarm if Arduino key 2 is triggered
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (serialPort1.BytesToRead > 0)
            {
                string line = serialPort1.ReadLine();
                line = line.Trim();
                if (line == "alarm")
                {
                    lbAlarmHistory.Items.Add(DateTime.Now.ToString("HH:mm") + " Alarm on");
                    lblColor.BackColor = Color.Red;
                    timer2.Stop();
                }
            }
        }

        // third timer triggers alarm if tempature is below 16°C or above 27°C
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (serialPort1.BytesToRead > 0)
            {
                string line = serialPort1.ReadLine();
                line = line.Trim();
                if (line == "below 16")
                {
                    lbAlarmHistory.Items.Add("Temperature below 16°C");
                    lblColor.BackColor = Color.Red;
                }
                else if (line == "above 27")
                {
                    lbAlarmHistory.Items.Add("Temperature above 27°C");
                    lblColor.BackColor = Color.Red;
                }
            }
        }

        // fourth timer displays the current tempature every 5 sec
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (serialPort1.BytesToRead > 0)
            {
                string line = serialPort1.ReadLine();
                line = line.Trim();
                if (line == "temp")
                {
                    lblTemperature.Text = serialPort1.ReadLine();
                }
            }
        }
    }
}
