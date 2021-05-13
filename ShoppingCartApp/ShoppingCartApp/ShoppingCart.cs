using System.Collections.Generic;

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

        public double GetTotalPrice()
        {
            double total = 0;
            products.ForEach(i => total += i.GetPrice() * i.GetQuantity());
            return total;
        }

        public void EmptyCart()
        {
            products.Clear();
        }
    }
}