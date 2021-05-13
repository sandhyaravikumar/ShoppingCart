using System;

namespace ShoppingCartApp
{
    public class EWallet : IEWallet
    {
        private double balance;

        public EWallet(double balance)
        {
            this.balance = balance;
        }

        public double GetBalance()
        {
            return balance;
        }

        public double AddAmount(double amount)
        {
            return balance += amount;
        }

        public double DeductAmount(double amount)
        {
            if (balance > amount)
            {
                return balance -= amount;
            }
            throw new Exception("Insufficient Balance. Please add money to proceed further");
        }
    }
}