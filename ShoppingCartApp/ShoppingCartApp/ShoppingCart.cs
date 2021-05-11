using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingCartApp
{
    public class ShoppingCart
    {
        private List<ItemOrder> OrderItems;

        public ShoppingCart()
        {
            OrderItems = new List<ItemOrder>();
        }

        public void AddItem(ItemOrder item)
        {
            OrderItems.Add(item);
        }

        public void removeItem(ItemOrder item)
        {
            OrderItems.Remove(item);
        }

        public int totalNumberOfItems()
        {
            return OrderItems.Count();
        }

        public void AddItem(object itemOrder1)
        {
            throw new NotImplementedException();
        }

        public double totalPriceOfItemsPurchased()
        {
            double total = 0;
            OrderItems.ForEach(i => total += i.TotalCost());
            return total;
        }

        public void pay(eWallet eWallet)
        {
            double amount = totalPriceOfItemsPurchased();
            eWallet.pay(amount);
        }
    }
}