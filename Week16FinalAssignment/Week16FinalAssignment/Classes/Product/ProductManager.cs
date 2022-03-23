using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week16FinalAssignment
{
    public class ProductManager
    {
        private List<Product> products;

        public ProductManager()
        {
            this.products = new List<Product>();
        }

        public bool Add (Product product)
        {
            foreach (Product p in products)
            {
                if (p.Name == product.Name)
                {
                    return false;
                }
            }

            products.Add(product);

            return true;
        }
    }
}