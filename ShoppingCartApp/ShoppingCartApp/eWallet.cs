using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    public class eWallet
    {
        private string emailID;
        private string password;


        public eWallet(string emailID, string password)
        {
            this.emailID = emailID;
            this.password = password;
        }

        public void pay(double amount)
        {
            Console.WriteLine($"{amount} paid using eWallet");
        }
    }
}
