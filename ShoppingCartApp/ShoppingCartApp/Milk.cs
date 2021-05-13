using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    public class Milk: IProduct
    {
        public enum Categories
        {
            TonedMilk,
            FullCreamMilk,
            StandardizedMilk,
        }

        private string name;
        private double price;
        private Categories type;
        private int quantity;

        public Milk(string name,Categories type, double price, int quantity)
        {
            this.price = price;
            this.quantity = quantity;
            this.name = name;
            this.type = type;
        }

        public double GetPrice()
        {
            return price;
        }

        public Categories GetType()
        {
            return type;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public string GetName()
        {
            return name;
        }
    }
}
