using System;
using System.Linq;

public class clsClient
{
    public static int ID = 0;
    public static string USER = "";

    public bool getClient(string Username, string Password)
    {
        try
        {
            WebshopEntities db = new WebshopEntities();
            Client client = (from x in db.Clients
                             where x.UserName == Username && x.Password == Password
                             select x).FirstOrDefault();

            ID = client.Id;
            return true;
        }
        catch
        {
            return false;
        }
    }

    public string InsertClient(Client info)
    {
        WebshopEntities db = new WebshopEntities();
        db.Clients.Add(info);
        db.SaveChanges();

        return "Uw bent geregistreerd";
    }

    public void DeleteClient(int clientId)
    {
        WebshopEntities db = new WebshopEntities();
        Client client = db.Clients.Find(clientId);

        db.Clients.Attach(client);
        db.Clients.Remove(client);
        db.SaveChanges();
    }

    public string UpdateClient(int clientId, Client client)
    {
        WebshopEntities db = new WebshopEntities();
        Client c = db.Clients.Find(clientId);

        c.UserName = client.UserName;
        c.Password = client.Password;
        c.FirstName = client.FirstName;
        c.Insertion = client.Insertion;
        c.LastName = client.LastName;
        c.Address = client.Address;
        c.Mail = client.Mail;

        db.SaveChanges();
        return "Uw gegevens zijn aangepast";
    }
}