using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refOutDemo
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

        public Person (string name, int age, string homeTown)
        {
            this.Name = name;
            this.Age = age;
            this.HomeTown = homeTown;
        }

        public bool TryParse (string input, out Person result)
        {
            if (!string.IsNullOrWhiteSpace(input))
            {
                if (input.Contains(','))
                {
                    string[] splitWords = input.Split(',');
                    if (splitWords.Length == 3)
                    {
                        int age;
                        if (int.TryParse(splitWords[1], out age))
                        {
                            result = new Person(splitWords[0], age, splitWords[2]);
                            return true;
                        }
                    }
                }
            }
            
            result = null;
            return false;
        }
    }
}
