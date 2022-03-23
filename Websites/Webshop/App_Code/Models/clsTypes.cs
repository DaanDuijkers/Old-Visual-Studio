using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class clsType
{
    public string InsertType(Type type)
    {
            WebshopEntities db = new WebshopEntities();
            db.Types.Add(type);
            db.SaveChanges();

            return type.TypeName + " is toegevoegd";
    }

    public string UpdateProductType(int id, Type productType)
    {
            WebshopEntities db = new WebshopEntities();
    
            Type p = db.Types.Find(id);

            p.TypeName = productType.TypeName;

            db.SaveChanges();
            return productType.TypeName + " was succesfully updated";
    }

    public string DeleteProductType(int id)
    {
            WebshopEntities db = new WebshopEntities();
            Type productType = db.Types.Find(id);

            db.Types.Attach(productType);
            db.Types.Remove(productType);
            db.SaveChanges();

            return productType.TypeName + " was succesfully deleted";
    }
}