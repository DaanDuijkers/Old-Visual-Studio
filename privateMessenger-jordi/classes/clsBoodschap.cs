using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace privateMessenger.classes
{
    class clsBoodschap
    {
        var buffer = new byte[mySerialPort.BytesToRead];

        private string id = System.Text.Encoding.ASCII.GetString(buffer);
        private string boodschap;
        private string datum = DateTime.Now.ToString("HH:mm");

        public string verstuur
        {
            get { return boodschap; }
            set
            {
                id = "@b";
                boodschap = value;
                datum = DateTime.Now.ToString("HH:mm");
            }
        }
    }
}
