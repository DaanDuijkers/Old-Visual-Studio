using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OopAssignment
{
    public class Shelter
    {
        private List<Animal> Animals;
        private List<Customer> Customers;
        private List<Adoption> Adoptions;
        Textfile textfile;

        public Shelter()
        {
            Animals = new List<Animal>();
            Customers = new List<Customer>();
            Adoptions = new List<Adoption>();
            textfile = new Textfile();
        }

        public void AddDog (string name, int age, string gender, string notes)
        {
            Animal animal = new Dog(name, age, gender, notes);
            Animals.Add(animal);

            string animalInfo = "ID: " + animal.ID.ToString();
            animalInfo += ". | Species: " + animal.Species;
            animalInfo += " | Name: " + animal.Name;
            animalInfo += " | Age: " + animal.Age.ToString();
            animalInfo += " | Gender: " + animal.Gender;
            animalInfo += " | Notes: " + animal.Notes;
            animalInfo += " | Price: " + animal.Price.ToString("0.00");
            SaveAction(animalInfo);
        }

        public void AddCat (string name, int age, string gender, string notes)
        {
            Animal animal = new Cat(name, age, gender, notes);
            Animals.Add(animal);

            string animalInfo = "ID: " + animal.ID.ToString();
            animalInfo += ". | Species: " + animal.Species;
            animalInfo += " | Name: " + animal.Name;
            animalInfo += " | Age: " + animal.Age.ToString();
            animalInfo += " | Gender: " + animal.Gender;
            animalInfo += " | Notes: " + animal.Notes;
            animalInfo += " | Price: " + animal.Price.ToString("0.00");
            SaveAction(animalInfo);
        }

        public void AddBird (string name, int age, string gender, string notes, string size)
        {
            Animal animal = new Bird(name, age, gender, notes, size);
            Animals.Add(animal);

            string animalInfo = "ID: " + animal.ID.ToString();
            animalInfo += ". | Species: " + animal.Species;
            animalInfo += " | Name: " + animal.Name;
            animalInfo += " | Age: " + animal.Age.ToString();
            animalInfo += " | Gender: " + animal.Gender;
            animalInfo += " | Notes: " + animal.Notes;
            animalInfo += " | Price: " + animal.Price.ToString("0.00");
            if (animal is Bird)
            {
                animalInfo += " | Size: " + ((Bird)animal).Size;
            }
            SaveAction(animalInfo);
        }

        public void AddCustomer(string name, string zipCode, string city)
        {
            Customer customer = new Customer(name, zipCode, city);
            Customers.Add(customer);

            string customerInfo = "ID: " + customer.ID.ToString();
            customerInfo += ". | Name: " + customer.Name;
            customerInfo += " | Zipcode: " + customer.ZipCode;
            customerInfo += " | City: " + customer.City;
            SaveAction(customerInfo);
        }

        public List<string> GetCustomers()
        {
            List<String> customerDetails = new List<String>();
            foreach (Customer c in Customers)
            {
                string customerInfo = "ID: " + c.ID.ToString();
                customerInfo += ". | Name: " + c.Name;
                customerInfo += " | Zipcode: " + c.ZipCode;
                customerInfo += " | City: " + c.City;

                customerDetails.Add(customerInfo);
            }
            return customerDetails;
        }

        public List<string> GetAnimals()
        {
            List<String> animalDetails = new List<String>();
            foreach (Animal a in Animals)
            {
                string animalInfo = "ID: " + a.ID.ToString();
                animalInfo += ". | Species: " + a.Species;
                animalInfo += " | Name: " + a.Name;
                animalInfo += " | Age: " + a.Age.ToString();
                animalInfo += " | Gender: " + a.Gender;
                animalInfo += " | Notes: " + a.Notes;
                animalInfo += " | Price: " + a.Price.ToString("0.00");
                if (a is Bird)
                {
                    animalInfo += " | Size: " + ((Bird)a).Size;
                }
                animalInfo += " | Adopted: " + a.Adopted.ToString();

                animalDetails.Add(animalInfo);
            }
            return animalDetails;
        }

        public void AddAdoption(int customerNumber, List<int> animalNumber)
        {
            bool isAdopted = false;

            Customer customer = Customers[customerNumber];
            List<Animal> animalList = new List<Animal>();
            int teller = 0;
            foreach (int an in animalNumber)
            {
                animalList.Add(Animals[animalNumber[teller]]);
                if (Animals[animalNumber[teller]].Adopted == true)
                {
                    isAdopted = true;
                }
                teller++;
            }

            if (isAdopted == true)
            {
                Adoption adoption = new Adoption(customer, animalList);
                Adoptions.Add(adoption);

                string adoptionInfo = "ID: " + adoption.ID.ToString();
                adoptionInfo += ". | Date: " + adoption.Date.ToString();
                adoptionInfo += " | Customer ID: " + adoption.Customer.ID.ToString();
                adoptionInfo += " | Customer Name: " + adoption.Customer.Name.ToString();
                int i = 0;
                foreach (Animal a in adoption.Animals)
                {
                    i++;
                    adoptionInfo += " | Animal " + i + " ID: " + a.ID.ToString();
                    adoptionInfo += " | Animal " + i + " Species: " + a.Species;
                    adoptionInfo += " | Animal " + i + " Name: " + a.Name;
                }
                adoptionInfo += " | Adoption Fee: " + ad.AdoptionFee.ToString();

                SaveAction(adoptionInfo);
            }
            else
            {
                MessageBox.Show("One of these animals has already been adopted");
            }
        }

        public List<string> GetAdoptions()
        {
            List<String> adoptionDetails = new List<String>();
            foreach (Adoption ad in Adoptions)
            {
                string adoptionInfo = "ID: " + ad.ID.ToString();
                adoptionInfo += ". | Date: " + ad.Date.ToString();
                adoptionInfo += " | Customer ID: " + ad.Customer.ID.ToString();
                adoptionInfo += " | Customer Name: " + ad.Customer.Name.ToString();
                int teller = 0;
                foreach (Animal a in ad.Animals)
                {
                    teller++;
                    adoptionInfo += " | Animal " + teller + " ID: " + a.ID.ToString();
                    adoptionInfo += " | Animal " + teller + " Species: " + a.Species;
                    adoptionInfo += " | Animal " + teller + " Name: " + a.Name;
                }
                adoptionInfo += " | Adoption Fee: " + ad.AdoptionFee.ToString();

                adoptionDetails.Add(adoptionInfo);
            }
            return adoptionDetails;
        }

        private void SaveAction (string action)
        {
            textfile.Save(action);
        }

        private List<string> GetAction()
        {
            return textfile.AllActivities;
        }
    }
}
