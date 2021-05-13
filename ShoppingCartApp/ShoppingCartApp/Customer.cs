using System.Collections.Generic;
using System.Linq;

namespace ShoppingCartApp
{
    public class Customer
    {
        private string name;
        private eWallet wallet;
        private ShoppingCart cart;

        public Customer(string name, double amount)
        {
            this.name = name;
            wallet = new eWallet(amount);
            cart = new ShoppingCart();
        }

        public void AddToCart(IProduct product)
        {
            cart.AddProduct(product);
        }

        public void RemoveFromCart(IProduct product)
        {
            cart.RemoveProduct(product);
        }

        private double TotalAmount()
        {
            return cart.getTotalPrice();
        }

        public double GetBalance()
        {
            return wallet.getBalance();
        }

        public double PayFromEWallet()
        {
            double balance = wallet.DeductAmount(TotalAmount());
            return balance;
        }
    }
}