using System;

public class clsWedstrijd
{
    public string InsertWedstrijd(WEDSTRIJD wedstrijd)
    {
        try
        {
            TennistoernooiEntities db = new TennistoernooiEntities();
            db.WEDSTRIJDs.Add(wedstrijd);
            db.SaveChanges();

            return "Wacht even...";
        }
        catch (Exception ex)
        {
            return ex.ToString();
        }
    }

    public string UpdateProduct(int id, WEDSTRIJD wedstrijd)
    {
        TennistoernooiEntities db = new TennistoernooiEntities();

        WEDSTRIJD w = db.WEDSTRIJDs.Find(id);

        w.Score1 = wedstrijd.Score1;
        w.Score2 = wedstrijd.Score2;
        w.Winnaar_Id = wedstrijd.Winnaar_Id;

        db.SaveChanges();
        return "Wacht even";
}
}