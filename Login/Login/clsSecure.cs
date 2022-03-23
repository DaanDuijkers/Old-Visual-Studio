using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class clsSecure
    {
        public bool checkPage(string pagename)
        {
            // False = geef inlogpagina
            // True = show content
            switch (pagename)
            {
                case "aanpassen": return false;
            }

            return false;
        }
    }
}
