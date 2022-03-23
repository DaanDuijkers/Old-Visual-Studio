using System;

public class clsSpeler
{
    public string InsertSpeler(SPELER speler)
    {
        try
        {
            TennistoernooiEntities db = new TennistoernooiEntities();
            db.SPELERs.Add(speler);
            db.SaveChanges();

            return "Wacht even...";
        }
        catch (Exception ex)
        {
            return ex.ToString();
        }
    }
}