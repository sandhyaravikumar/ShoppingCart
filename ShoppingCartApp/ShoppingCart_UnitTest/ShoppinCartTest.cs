using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartApp;
using System;

namespace ShoppingCart_UnitTest
{
    [TestClass]
    public class ShoppinCartTest
    {
        private Customer sandhya;

        [TestInitialize()]
        public void Initialize()
        {
            sandhya = new Customer("Sandhya", 1000);
        }

        [TestMethod()]
        public void should_checkout_cart()
        {
            Apple apple = new Apple("Apple", Apple.Categories.CameoApple, 65, 2);
            Milk milk = new Milk("Milk", Milk.Categories.FullCreamMilk, 30, 2);
            Newspaper newspaper = new Newspaper("Newspaper", Newspaper.Categories.TheIndianExpress, 3, 1);

            sandhya.AddToCart(apple);
            sandhya.AddToCart(milk);
            sandhya.AddToCart(newspaper);

            sandhya.PayFromEWallet();

            double EwalletUpdatedBalance = sandhya.GetBalance();

            Console.WriteLine($"Order placed Successfully. Available Balance in your E-Wallet is Rs.{EwalletUpdatedBalance}");
            Assert.AreEqual(807, EwalletUpdatedBalance, "Mismatch in EWallet Balance, Please check again");
        }

        [TestMethod()]
        public void should_remove_item_from_cart()
        {
            Apple apple = new Apple("Apple", Apple.Categories.CameoApple, 65, 2);
            Milk milk = new Milk("Milk", Milk.Categories.FullCreamMilk, 30, 2);
            Newspaper newspaper = new Newspaper("Newspaper", Newspaper.Categories.TheIndianExpress, 3, 1);

            sandhya.AddToCart(apple);
            sandhya.AddToCart(milk);
            sandhya.AddToCart(newspaper);

            sandhya.RemoveFromCart(milk);

            sandhya.PayFromEWallet();

            double EwalletUpdatedBalance = sandhya.GetBalance();

            Console.WriteLine($"Order placed Successfully. Available Balance in your E-Wallet is Rs.{EwalletUpdatedBalance}");
            Assert.AreEqual(867, EwalletUpdatedBalance, "Mismatch in EWallet Balance, Please check again");
        }
    }
}