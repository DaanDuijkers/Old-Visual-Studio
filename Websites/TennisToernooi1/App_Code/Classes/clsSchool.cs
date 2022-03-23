using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class clsSchool
{
    public string InsertSchool(SCHOOL school)
    {
        try
        {
            TennistoernooiEntities db = new TennistoernooiEntities();
            db.SCHOOLs.Add(school);
            db.SaveChanges();

            return "Wacht even...";
        }
        catch (Exception ex)
        {
            return ex.ToString();
        }
    }
}