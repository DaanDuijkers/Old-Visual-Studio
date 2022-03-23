using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookstore
{
    public partial class Form1 : Form
    {
        Boek boek1 = new Boek();
        Boek boek2 = new Boek();
        Boek boek3 = new Boek();
        int selected = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string s = "";
            switch (selected)
            {
                case 1: this.boek1.setNaam("test"); break;
                case 2: this.boek2.setNaam("hooi"); break;
                case 3: this.boek3.setNaam("bladeren"); break;
            }
            
        }
    }
}
