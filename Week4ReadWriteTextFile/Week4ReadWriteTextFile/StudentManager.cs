using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4ReadWriteTextFile
{
    public class StudentManager
    {
        List<Student> students;

        public StudentManager ()
        {
            students = new List<Student>();
        }

        public void AddStudent (Student student)
        {
            students.Add(student);
        }

        public List<Student> GetStudents ()
        {
            return students;
        }

        public void WriteToTextFile()
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                fs = new FileStream("demo.txt", FileMode.Append, FileAccess.Write);
                fs.Seek(0, SeekOrigin.End);
                sw = new StreamWriter(fs);

                foreach (Student s in students)
                {
                    sw.WriteLine(s.Name + " " + s.Grade);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error writing file \r\n\r\n" + ex.ToString());
            }
            finally
            { 
                if (sw != null)
                { 
                    sw.Close(); 
                } 
            }
        }

        public void ReadFromTextFile()
        {
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream("demo.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    string[] words = line.Split(' ');

                    Student s = new Student(words[0], words[1]);
                    students.Add(s);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error writing file \r\n\r\n" + ex.ToString());
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}
