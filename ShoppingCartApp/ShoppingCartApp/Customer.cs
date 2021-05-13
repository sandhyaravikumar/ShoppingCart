using System;
using System.Collections.Generic;

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

        public void CheckOutCart(ShoppingCart product)
        {
            cart.Add(product);
        }

        private double totalAmountTobePaid()
        {
            double total = 0;
            cart.ForEach(c => total += c.totalPriceOfItemsPurchased());
            return total;
        }

        public double getBalance()
        {
            return wallet.DeductAmount(totalAmountTobePaid());
        }
    }
}