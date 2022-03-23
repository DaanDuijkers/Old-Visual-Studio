using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4ReadWriteTextFile
{
    public class Student
    {
        private string grade;

        public string Name { get; set; }
        public string Grade { 
            get { return grade; } 
            set {
                string[] grades = new string[] { "O", "G", "S", "U", "P" };
                if (grades.Contains(value))
                {
                    grade = value;
                }
                else
                {
                    throw new Exception(value);
                }
            } 
        }

        public Student(string name, string grade)
        {
            Name = name;
            Grade = grade;
        }

        public override string ToString ()
        {
            return Name + " " + Grade;
        }
    }
}
