using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    public class Newspaper: IProduct
    {
        public enum Categories
        {
            TheHindu,
            TheIndianExpress,
            TimesOfIndia
        }

        private string name;

        private double price;
        
        private Categories type;

        private int quantity;

        public Newspaper(string name, Categories type, double price, int quantity)
        {
            this.price = price;
            this.quantity = quantity;
            this.name = name;
            this.type = type;
        }

        public double getPrice()
        {
            return price;
        }

        public Categories getType()
        {
            return type;
        }
        public int getQuantity()
        {
            return quantity;
        }

        public string getName()
        {
            return name;
        }
    }
}
