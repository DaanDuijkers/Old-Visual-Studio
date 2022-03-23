using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
        }

        private void btnTurnOn_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("On");
        }

        private void btnTurnOff_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("Off");
        }
    }
}
