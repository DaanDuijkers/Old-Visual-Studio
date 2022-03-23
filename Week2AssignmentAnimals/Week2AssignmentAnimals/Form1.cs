using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2AssignmentAnimals
{
    public partial class Form1 : Form
    {
        private AnimalManager animalManager;

        public Form1()
        {
            InitializeComponent();

            animalManager = new AnimalManager();
            cmbType.SelectedIndex = 0;
        }

        private void GetAllAnimals ()
        {
            lbAnimals.Items.Clear();

            foreach (String a in animalManager.GetAllAnimals())
            {
                lbAnimals.Items.Add(a);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbName.Text != string.Empty)
            {
                animalManager.AddAnimal(txbName.Text, cmbType.Text);
                txbName.Text = string.Empty;
                cmbType.SelectedIndex = 0;
                GetAllAnimals();
            }
            else
            {
                MessageBox.Show("Please put in a name for the animal");
            }
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            MessageBox.Show(animalManager.Speak(lbAnimals.SelectedIndex));
        }
    }
}
