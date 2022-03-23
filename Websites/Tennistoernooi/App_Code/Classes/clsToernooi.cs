using System;

public class clsToernooi
{
    public string InsertToernooi(TOERNOOI toernooi)
    {
        try
        {
            TennistoernooiEntities db = new TennistoernooiEntities();
            db.TOERNOOIs.Add(toernooi);
            db.SaveChanges();

            return "Wacht even...";
        }
        catch (Exception ex)
        {
            return ex.ToString();
        }
    }
}