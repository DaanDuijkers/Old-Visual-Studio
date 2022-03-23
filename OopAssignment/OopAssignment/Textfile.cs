using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OopAssignment
{
    public class Textfile
    {
        private string filePath;
        private List<string> allActivities = new List<string>();

        public string FilePath { get { return filePath; } set { filePath = value; } }
        public List<string> AllActivities { get { return allActivities; } set { allActivities = value; } }

        public Textfile ()
        {
            this.FilePath = "../../allActivities.txt";
            this.AllActivities = File.ReadAllLines(filePath).ToList();
        }

        public void Save (string activity)
        {
            this.AllActivities = File.ReadAllLines(filePath).ToList();
            this.AllActivities.Add(activity);
            File.WriteAllLines(filePath, AllActivities);
        }
    }
}
