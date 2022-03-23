using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class clsProducten
{
    public string InsertProduct(Product product)
    {
        WebshopEntities db = new WebshopEntities();
        db.Products.Add(product);
        db.SaveChanges();

        return product.Name + " is toegevoegd!";
    }

    public string UpdateProduct(int id, Product product)
    {
        WebshopEntities db = new WebshopEntities();

        Product p = db.Products.Find(id);

        p.Name = product.Name;
        p.Price = product.Price;
        p.TypeId = product.TypeId;
        p.Description = product.Description;
        p.Image = product.Image;

        db.SaveChanges();
        return product.Name + " is aangepast";
    }

    public string DeleteProduct(int id)
    {
        WebshopEntities db = new WebshopEntities();
        Product product = db.Products.Find(id);

        db.Products.Attach(product);
        db.Products.Remove(product);
        db.SaveChanges();

        return product.Name + " is aangepast";
    }

    public Product GetProduct(int id)
    {
            using (WebshopEntities db = new WebshopEntities())
            {
                Product product = db.Products.Find(id);
                return product;
            }
    }

    public List<Product> GetAllProducts()
    {
            using (WebshopEntities db = new WebshopEntities())
            {
                List<Product> products = (from x in db.Products select x).ToList();

                return products;
            }
    }

    public List<Product> GetProductsByType(int typeId)
    {
            using (WebshopEntities db = new WebshopEntities())
            {
                List<Product> products = (from x in db.Products where x.TypeId == typeId select x).ToList();
                return products;
            }
    }
}