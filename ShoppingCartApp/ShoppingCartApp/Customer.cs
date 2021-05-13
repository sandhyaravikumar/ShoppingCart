using System.Collections.Generic;
using System.Linq;

namespace ShoppingCartApp
{
    public class Customer
    {
        private string name;
        private eWallet wallet;
        private List<ShoppingCart> cart;

        public Customer(string name, double amount)
        {
            this.name = name;
            wallet = new eWallet(amount);
            cart = new List<ShoppingCart>();
        }

        public void AddCart(ShoppingCart product)
        {
            cart.Add(product);
        }

        private double TotalAmount()
        {
            return cart.Where(c => c.getTotalPrice() > 0)
                       .Select(c => c.getTotalPrice())
                       .FirstOrDefault();
        }

        public double GetBalance()
        {
            double balance = wallet.DeductAmount(TotalAmount());
            return balance;
        }
    }
}