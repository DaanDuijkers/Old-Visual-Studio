using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopWeek1Assignment1
{
    public class AnimalManager
    {
        private List<Animal> animals;
        
        public AnimalManager ()
        {
            this.animals = new List<Animal>();
        }

        public void AddAnimal (Animal animal)
        {
            this.animals.Add(animal);
        }

        public List<string> GetAnimals ()
        {
            List<string> strings = new List<string>();

            foreach (Animal a in this.animals)
            {
                strings.Add(a.ToString());
            }

            return strings;
        }
    }
}