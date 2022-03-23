using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoStreetApp
{
    public partial class NotifierForm : Form, IMapClient
    {
        public NotifierForm()
        {
            InitializeComponent();
        }

        public void StreetAdded(Street s)
        {
            lblStreetInfo.Text = "Added: " + s.ToString();
            BackColor = Color.Green;
        }

        public void StreetRemoved(Street s)
        {
            lblStreetInfo.Text = "Removed: " + s.ToString();
            BackColor = Color.Red;
        }
    }
}
