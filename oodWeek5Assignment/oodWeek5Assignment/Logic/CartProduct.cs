using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oodWeek5Assignment
{
    public class CartProduct
    {
        private int id;
        private Product product;
        private int quantity;
        private float totalPrice;
        private static int counter;

        public int ID { get { return this.id; } }
        public Product Product { get { return this.product; } set { this.product = value; } }
        public int Quantity { get { return this.quantity; } set { this.quantity = value; } }
        public float TotalPrice { get { return this.totalPrice; } set { this.totalPrice = value; } }

        public CartProduct (Product product, int quantity)
        {
            this.id = counter;
            this.Product = product;
            this.Quantity = quantity;
            this.TotalPrice = this.Product.Price * this.Quantity;
            counter++;
        }
    }
}