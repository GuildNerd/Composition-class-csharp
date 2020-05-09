using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc3_Enum_Comp.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Product.Price.ToString("F2")
                + ", Quantity: "
                + Quantity.ToString()
                + ", Subtotal: $"
                + SubTotal().ToString("F2");
        }
    }
}
