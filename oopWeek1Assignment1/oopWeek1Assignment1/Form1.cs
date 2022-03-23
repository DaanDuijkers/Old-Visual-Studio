using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oopWeek1Assignment1
{
    public partial class Form1 : Form
    {
        private AnimalManager animalManager;
        public Form1()
        {
            InitializeComponent();

            animalManager = new AnimalManager();

            animalManager.AddAnimal(new Dog ("Dog"));
            animalManager.AddAnimal(new Dog ("Dog", 2));
            animalManager.AddAnimal(new Cat ("Cat"));
            animalManager.AddAnimal(new Cat ("Cat", 2));
            animalManager.AddAnimal(new Turtle ("Turtle"));
            animalManager.AddAnimal(new Turtle ("Turtle", 2));

            foreach (string animal in animalManager.GetAnimals())
            {
                lbAnimals.Items.Add(animal);
            }
        }
    }
}
