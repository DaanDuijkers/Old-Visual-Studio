using System;
using System.Collections.Generic;
using System.Linq;

public class CartModel
{
    public string InsertCart(Cart cart)
    {
        try
        {
            GarageEntities db = new GarageEntities();
            db.Carts.Add(cart);
            db.SaveChanges();

            return cart.DatePurchased + " was succesfully inserted";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }

    public string UpdateCart(int id, Cart cart)
    {
        try
        {
            GarageEntities db = new GarageEntities();
            
            Cart p = db.Carts.Find(id);

            p.DatePurchased = cart.DatePurchased;
            p.ClientId = cart.ClientId;
            p.Amount = cart.Amount;
            p.IsInCart = cart.IsInCart;
            p.ProductId = cart.ProductId;

            db.SaveChanges();
            return cart.DatePurchased + " was succesfully updated";

        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }

    public string DeleteCart(int id)
    {
        try
        {
            GarageEntities db = new GarageEntities();
            Cart cart = db.Carts.Find(id);

            db.Carts.Attach(cart);
            db.Carts.Remove(cart);
            db.SaveChanges();

            return cart.DatePurchased + " was succesfully deleted";
        }
        catch (Exception e)
        {
            return "Error: " + e;
        }
    }
    
    public List<Cart> GetOrdersInCart(string userId)
    {
        GarageEntities db = new GarageEntities();
        List<Cart> orders = (from x in db.Carts
                                 where x.ClientId == userId && x.IsInCart
                                 orderby x.DatePurchased
                                 select x).ToList();

        return orders;
    }

    public int GetAmountOfOrders(string userId)
    {
        try
        {
            GarageEntities db = new GarageEntities();
            int amount = (from x in db.Carts where x.ClientId == userId && x.IsInCart select x.Amount).Sum();

            return amount;
        }
        catch
        {
            return 0;
        }
    }

    public void UpdateQuantity(int id, int quality)
    {
        GarageEntities db = new GarageEntities();
        Cart cart = db.Carts.Find(id);
        cart.Amount = quality;

        db.SaveChanges();
    }

    public void MarkOrderAsPaid(List<Cart> carts)
    {
        GarageEntities db = new GarageEntities();

        if (carts != null)
        {
            foreach (Cart cart in carts)
            {
                Cart oldCart = db.Carts.Find(cart.Id);
                oldCart.DatePurchased = DateTime.Now;
                oldCart.IsInCart = false;
            }

            db.SaveChanges();
        }
    }
}