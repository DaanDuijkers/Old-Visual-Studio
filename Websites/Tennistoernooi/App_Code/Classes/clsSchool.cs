using System;

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