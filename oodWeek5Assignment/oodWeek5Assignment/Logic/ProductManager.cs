using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oodWeek5Assignment
{
    public class ProductManager
    {
        private List<Product> products;

        public ProductManager()
        {
            products = new List<Product>();
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public Product Get(int id)
        {
            foreach (Product p in products)
            {
                if (p.ID == id)
                {
                    return p;
                }
            }

            return null;
        }

        public bool Add (Product product)
        {
            products.Add(product);
            return true;
        }

        public bool Edit (int id, Product newProduct)
        {
            int i = 0;
            foreach (Product p in products)
            {
                if (p.ID == id)
                {
                    products[i] = newProduct;
                    return true;
                }
                i++;
            }

            return false;
        }

        public bool Remove (int id)
        {
            foreach (Product p in products)
            {
                if (p.ID == id)
                {
                    products.Remove(p);
                    return true;
                }
            }

            return false;
        }

        public bool Restock (int id, int quantity)
        {
            foreach (Product p in products)
            {
                if (p.ID == id)
                {
                    p.InStock += quantity;
                    return true;
                }
            }

            return false;
        }
    }
}