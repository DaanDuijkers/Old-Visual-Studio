using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week16FinalAssignment
{
    public class PlayroomProduct
    {
        private List<ProductAvailability> products;

        public List<ProductAvailability> Products { get { return this.products; } set { this.products = value; } }

        public PlayroomProduct(ProductAvailability product, int quantity)
        {
            this.products = new List<ProductAvailability>();

            for (int i = 1; i <= quantity; i++)
            {
                products.Add(product);
            }
        }
    }
}