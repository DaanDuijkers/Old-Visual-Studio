using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsSecure
/// </summary>
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