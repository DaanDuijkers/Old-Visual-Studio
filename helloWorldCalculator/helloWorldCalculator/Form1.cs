using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helloWorldCalculator
{
    public partial class Form1 : Form
    {
        int selectedItem = 0;

        public Form1()
        {
            InitializeComponent();
            cmbLanguage.SelectedIndex = selectedItem;
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            selectedItem = cmbLanguage.SelectedIndex;
            switch (selectedItem)
            {
                case 0:
                    txbOutput.Text = "Hallo Wereld!";
                    break;
                case 1:
                    txbOutput.Text = "Hallo Welt!";
                    break;
                case 2:
                    txbOutput.Text = "Bonjour le monde!";
                    break;
                case 3:
                    txbOutput.Text = "Ciao mondo!";
                    break;
                case 4:
                    txbOutput.Text = "¡Hola Mundo!";
                    break;
                case 5:
                    txbOutput.Text = "Olá Mundo!";
                    break;
                case 6:
                    txbOutput.Text = "Здравей свят!";
                    break;
            }
        }
    }
}
