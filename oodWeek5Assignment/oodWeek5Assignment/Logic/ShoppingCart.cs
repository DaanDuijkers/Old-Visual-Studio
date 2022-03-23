using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oodWeek5Assignment
{
    public class ShoppingCart
    {
        private List<CartProduct> cartProducts;
        private ProductManager productManager;

        public ShoppingCart(ProductManager productManager)
        {
            this.cartProducts = new List<CartProduct>();
            this.productManager = productManager;
        }

        public List<CartProduct> GetAll()
        {
            return this.cartProducts;
        }

        public CartProduct Get (int id)
        {
            foreach (CartProduct cp in cartProducts)
            {
                if (cp.ID == id)
                {
                    return cp;
                }
            }

            return null;
        }

        public bool Add (Product product, int quantity)
        {
            int inStock = productManager.Get(product.ID).InStock;
            int after = inStock -= quantity;
            if (after > -1)
            {
                productManager.Get(product.ID).InStock -= quantity;
            }
            else
            {
                return false;
            }

            foreach (CartProduct cp in cartProducts)
            {
                if (cp.Product.ID == product.ID)
                {
                    cp.Quantity += quantity;
                    cp.TotalPrice += product.Price * quantity;
                    return true;
                }
            }

            this.cartProducts.Add(new CartProduct(product, quantity));
            return true;
        }

        public bool Return (int id, int quantity)
        {
            foreach(CartProduct cp in cartProducts)
            {
                if (cp.ID == id)
                {
                    cp.Quantity -= quantity;
                    cp.Product.InStock += quantity;

                    if (cp.Quantity == 0)
                    {
                        cartProducts.Remove(cp);
                    }

                    return true;
                }
            }

            return false;
        }

        public bool ReturnAll ()
        {
            if (cartProducts.Count < 1)
            {
                cartProducts.Clear();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}