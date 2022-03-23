using System;

public class clsAanmeldingen
{
    public string InsertAanmelding(AANMELDING aanmelding)
    {
        try
        {
            TennistoernooiEntities db = new TennistoernooiEntities();
            db.AANMELDINGs.Add(aanmelding);
            db.SaveChanges();

            return "Wacht even...";
        }
        catch (Exception ex)
        {
            return ex.ToString();
        }
    }
}