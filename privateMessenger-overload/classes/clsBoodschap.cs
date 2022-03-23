using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace privateMessenger.classes
{
    class clsBoodschap
    {
        private string id = "@b";
        private string Boodschap;
        private string datum = DateTime.Now.ToString("HH:mm");

        public string boodschap
        {
            get { return Boodschap; }
            set { Boodschap = value; }
        }
    }
}
