using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carSystem
{
    public partial class Form1 : Form
    {
        bool alarm = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
            serialPort1.WriteLine("normal");
            //timer1.Start();
            //timer1.Enabled = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
                serialPort1.WriteLine("normal");
                alarm = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string line = serialPort1.ReadLine();
            line = line.Trim();
            if (line == "Lights on")
            {
                txbHeadlight.Text = "On";
            }
            else if (line == "Lights off")
            {
                txbHeadlight.Text = "Off";
            }
        }
    }
}
