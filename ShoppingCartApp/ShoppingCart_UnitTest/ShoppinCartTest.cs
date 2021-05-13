using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartApp;
using System;

namespace ShoppingCart_UnitTest
{
    [TestClass]
    public class ShoppinCartTest
    {
        private ShoppingCart cart;
        private Customer sandhya;

        [TestInitialize()]
        public void Initialize()
        {
            cart = new ShoppingCart();
            sandhya = new Customer("Sandhya", 1000);
        }

        [TestMethod()]
        public void should_add_item_to_the_cart()
        {
            Apple apple = new Apple("Apple", Apple.Categories.CameoApple, 65, 2);
            Milk milk = new Milk("Milk", Milk.Categories.FullCreamMilk, 30, 2);

            cart.AddProduct(apple);
            cart.AddProduct(milk);

            double TotalItem = cart.totalNumberOfItems();
            Assert.AreEqual(2, TotalItem, "Mismatch in Total Number of Purchased Item, Please check again");
        }

        [TestMethod()]
        public void should_checkout_cart()
        {
            Apple apple = new Apple("Apple", Apple.Categories.CameoApple, 65, 2);
            Milk milk = new Milk("Milk", Milk.Categories.FullCreamMilk, 30, 2);
            Newspaper newspaper = new Newspaper("Newspaper", Newspaper.Categories.TheIndianExpress, 3, 1);

            cart.AddProduct(apple);
            cart.AddProduct(milk);
            cart.AddProduct(newspaper);

            double TotalPrice = cart.getTotalPrice();

            sandhya.AddCart(cart);

            double EwalletUpdatedBalance = sandhya.GetBalance();

            Console.WriteLine($"Total Amount Rs.{TotalPrice} paid using Ewallet. Available Balance is Rs.{EwalletUpdatedBalance}");
            Assert.AreEqual(193, TotalPrice, "Mismatch in TotalCost of Purchase, Please check again");
        }

        [TestMethod()]
        public void should_remove_item_from_cart()
        {
            Apple apple = new Apple("Apple", Apple.Categories.CameoApple, 65, 2);
            Milk milk = new Milk("Milk", Milk.Categories.FullCreamMilk, 30, 2);
            Newspaper newspaper = new Newspaper("Newspaper", Newspaper.Categories.TheIndianExpress, 3, 1);

            cart.AddProduct(apple);
            cart.AddProduct(milk);
            cart.AddProduct(newspaper);

            double TotalPrice = cart.getTotalPrice();
            Assert.AreEqual(193, TotalPrice, "Mismatch in TotalCost of Purchase, Please check again");

            cart.RemoveProduct(milk);

            double TotalPriceAfterRemovingItem = cart.getTotalPrice();
            Assert.AreEqual(133, TotalPriceAfterRemovingItem, "Mismatch in TotalCost of Purchase, Please check again");

            sandhya.AddCart(cart);
            double EwalletUpdatedBalance = sandhya.GetBalance();

            Console.WriteLine($"Total Amount Rs.{TotalPriceAfterRemovingItem} paid using Ewallet. Available Balance is Rs.{EwalletUpdatedBalance}");
        }
    }
}