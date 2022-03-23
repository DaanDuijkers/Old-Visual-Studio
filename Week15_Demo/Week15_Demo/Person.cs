using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week15_Demo
{
    class Person
    {
        private static int seederID = 1;
        private string firstName;
        private string lastName;
        private string gender;
        private int birthyear;
        private int personID;

        public Person (string firstName, string lastName, string gender, int birthyear)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.birthyear = birthyear;
            this.personID = seederID;
            seederID++;
        }

        public string FirstName
        {
            get { return firstName; }
            set 
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    firstName = value;
                }
            }
        }

        public string LastName 
        { 
            get { return lastName; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    lastName = value;
                }
            }
        }

        public string Gender
        {
            get { return gender; }
            set
            {
                if (gender == "female" || gender == "male")
                {
                    gender = value;
                }
                else
                {
                    MessageBox.Show("Gender is not selected!");
                }
            }
        }

        public int BirthYear
        {
            get { return birthyear; }
            set
            {
                if (value >= 0)
                {
                    birthyear = value;
                }
                else
                {
                    birthyear = 0;
                }
            }
        }

        public static int GetNumberOfPersons ()
        {
            return seederID - 1;
        }

        public string getInfo()
        {
            return personID + ". " + firstName + " " + lastName;
        }
    }
}
