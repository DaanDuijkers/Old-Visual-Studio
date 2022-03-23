using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2AssignmentAnimals
{
    public class AnimalManager
    {
        private List<Animal> animals;

        public AnimalManager ()
        {
            animals = new List<Animal>();
        }

        public void AddAnimal (string name, string type)
        {
            if (type == "Cat")
            {
                animals.Add(new Cat(name));
            }
            else if (type == "Dog")
            {
                animals.Add(new Dog(name));
            }
            else if (type == "Duck")
            {
                animals.Add(new Duck(name));
            }
        }

        public List<String> GetAllAnimals ()
        {
            List<String> allAnimals = new List<string>();

            foreach (Animal a in animals)
            {
                allAnimals.Add(a.ToString());
            }

            return allAnimals;
        }

        public string Speak (int position)
        {
            return animals[position].Speak();
        }
    }
}
