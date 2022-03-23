using System.Linq;

public class clsScheidsrechter
{
    public static int ID = 0;

    public bool getScheidsrechter(string Username, string Password)
    {
        try
        {
            TennistoernooiEntities db = new TennistoernooiEntities();
            SCHEIDSRECHTER scheidsrechter = (from x in db.SCHEIDSRECHTERs
                             where x.Gebruikersnaam == Username && x.Wachtwoord == Password
                             select x).FirstOrDefault();

            ID = scheidsrechter.Id;
            return true;
        }
        catch
        {
            return false;
        }
    }
}