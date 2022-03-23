using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAboutDogRaces
{
    public partial class Form1 : Form
    {
        private Person p1, p2, p3; // the 3 persons who will bet
        private Dog d1, d2, d3, d4;    // the 4 dogs, participants in a dog race

 

        public Form1()
        {
            InitializeComponent();
            this.p1 = new Person("Leon", 45);
            this.p2 = new Person("Gustavo", 200);
            this.p3 = new Person("Kristin"); 
            this.d1 = new Dog("Blacky", "still young, but a future champ");
            this.d2 = new Dog("Wolfie", "is really fast");
            this.d3 = new Dog("Rambo", "needs a hugh before racing");
            this.d4 = new Dog("scoffer", "a rough doggy");
        }

        private void showInfoPersons()
        {
            this.rbPerson1.Text = this.p1.GetInfo();
            this.rbPerson2.Text = this.p2.GetInfo();
            this.rbPerson3.Text = this.p3.GetInfo();
        }

        private void showInfoDogs()
        {
            this.rbDog1.Text = this.d1.GetInfo();
            this.rbDog2.Text = this.d2.GetInfo();
            this.rbDog3.Text = this.d3.GetInfo();
            this.rbDog4.Text = this.d4.GetInfo();
        }
        private void btnPlaceABet_Click(object sender, EventArgs e)
        {

        }

        private void btnStartRace_Click(object sender, EventArgs e)
        {

        }

        private void btnPayOut_Click(object sender, EventArgs e)
        {

        }
    }
}
