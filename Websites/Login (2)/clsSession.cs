using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsSession
/// </summary>
class clsSession
{
    private bool isLoggedIn { get; set; }

    public clsSession()
    {
        isLoggedIn = false;
    }

    public void setIsLoggedIn(bool loggedIn)
    {
        // Is IP juist?
        // Is username bekend?
        // Komt request van juiste netwerk?
        // Hoevaak is het request gedaan?
        // etc
        isLoggedIn = loggedIn;
    }

    public bool getLoggedIn()
    {
        return isLoggedIn;
    }
}