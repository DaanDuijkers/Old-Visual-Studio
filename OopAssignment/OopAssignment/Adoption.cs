using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAssignment
{
    public class Adoption
    {
        private int id;
        private DateTime date;
        private Customer customer;
        private List<Animal> animals;
        private double adoptionFee;
        private static int number = 0;

        public int ID { get { return id; } set { id = value; } }
        public DateTime Date { get { return date; } set { date = value; } }
        public Customer Customer { get { return customer; } set { customer = value; } }
        public List<Animal> Animals { get { return animals; } set { animals = value; } }
        public double AdoptionFee { get { return adoptionFee; } set { adoptionFee = value; } }

        public Adoption(Customer customer, List<Animal> animals)
        {
            number++;
            this.ID = number;
            this.Date = DateTime.Now;
            this.Customer = customer;
            this.Animals = animals;
            foreach (Animal a in Animals)
            {
                this.AdoptionFee += a.Price;
                a.Adopted = true;
            }
        }
    }
}
