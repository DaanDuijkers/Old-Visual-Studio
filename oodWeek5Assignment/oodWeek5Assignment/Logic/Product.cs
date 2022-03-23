using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oodWeek5Assignment
{
    public abstract class Product
    {
        protected int id;
        protected string type;
        protected string name;
        protected string description;
        protected float price;
        protected int inStock;
        protected ProductType productType;
        protected int height;
        protected int width;
        protected int depth;
        protected static int counter = 1;

        public int ID { get { return this.id; } }
        public string Type { get { return this.type; } set { this.type = value; } }
        public string Name { get { return this.name; } set { this.name = value; } }
        public string Description { get { return this.description; } set { this.description = value; } }
        public float Price { get { return this.price; } set { this.price = value; } }
        public int InStock { get { return this.inStock; } set { this.inStock = value; } }
        public ProductType ProductType { get { return this.productType; } set { this.productType = value; } }
        public int Height { get { return this.height; } set { this.height = value; } }
        public int Width { get { return this.width; } set { this.width = value; } }
        public int Depth { get { return this.depth; } set { this.depth = value; } }

        public Product (string name, string description, float price, int instock, ProductType productType, int height, int width, int depth)
        {
            this.id = counter;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.InStock = instock;
            this.ProductType = productType;
            this.Height = height;
            this.Width = width;
            this.Depth = depth;
            counter++;
        }
    }
}