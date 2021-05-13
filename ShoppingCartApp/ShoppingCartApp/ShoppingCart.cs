using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCartApp
{
    public class ShoppingCart
    {
        private List<IProduct> products;

        public ShoppingCart()
        {
            products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            products.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            products.Remove(product);
        }

        public double getTotalPrice()
        {
            double total = 0;
            products.ForEach(i => total += i.getPrice() * i.getQuantity());
            return total;
        }

    }
}