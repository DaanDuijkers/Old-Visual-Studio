using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preExam
{
    class Brewer
    {
        private string name;
        private string id;
        private static int nextFreeNr = 100;

        public string ID { get { return id; } set { id = value; } }

        public Brewer (string name)
        {
            this.name = name;
            nextFreeNr++;
            ID = nextFreeNr.ToString();
        }

        public string getInfo ()
        {
            string b = "C2020_" + ID;
            return b;
        }
    }
}
