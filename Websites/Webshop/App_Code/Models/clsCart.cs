using System;
using System.Collections.Generic;
using System.Linq;

public class clsCart
{
    public string InsertCart(Cart cart)
    {
        try
        {
            WebshopEntities db = new WebshopEntities();
            db.Carts.Add(cart);
            db.SaveChanges();

            return "Toegevoegd aan winkelmandje";
        }
        catch(Exception e)
        {
            return "Error " + e;
        }
            
    }

    public string UpdateCart(int id, Cart cart)
    {
            WebshopEntities db = new WebshopEntities();
        
            Cart p = db.Carts.Find(id);
        
            p.ClientId = cart.ClientId;
            p.Amount = cart.Amount;
            p.IsInCart = cart.IsInCart;
            p.ProductId = cart.ProductId;

            db.SaveChanges();
            return "Aangepast in winkelmandje";
    }

    public string DeleteCart(int id)
    {
            WebshopEntities db = new WebshopEntities();
            Cart cart = db.Carts.Find(id);

            db.Carts.Attach(cart);
            db.Carts.Remove(cart);
            db.SaveChanges();

            return "Uit winkelmandje verwijderd";
    }

    public List<Cart> GetOrdersInCart(int userId)
    {
        WebshopEntities db = new WebshopEntities();
        List<Cart> orders = (from x in db.Carts where x.ClientId == userId && x.IsInCart orderby x.Id
                             select x).ToList();

        return orders;
    }

    public int GetAmountOfOrders(int userId)
    {
            WebshopEntities db = new WebshopEntities();
            int amount = (from x in db.Carts
                          where x.ClientId == userId
                          && x.IsInCart
                          select x.Amount).Sum();

            return amount;
    }

    public void UpdateQuantity(int id, int quality)
    {
        WebshopEntities db = new WebshopEntities();
        Cart cart = db.Carts.Find(id);
        cart.Amount = quality;

        db.SaveChanges();
    }
}