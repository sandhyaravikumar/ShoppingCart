using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    public class eWallet: IEWallet
    {
        private double balance;

        public eWallet(double balance)
        {
            this.balance = balance;
        }

        public double getBalance()
        {
            return balance;
        }

        public double AddAmount(double amount)
        {
            return balance = balance + amount; 
        }

        public double DeductAmount(double amount)
        {
            if(balance > amount)
            {
                return balance = balance - amount;
            }
            throw new Exception("Insufficient Balance. Please add money to proceed further");
        }



    }
}
