using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartApp;

namespace ShoppingCart_UnitTest
{
    [TestClass]
    public class ShoppinCartTest
    {
        ShoppingCart cart;

        [TestInitialize()]
        public void Initialize()
        {
            cart = new ShoppingCart();
        }

        [TestMethod()]
        public void should_add_item_to_the_cart()
        {
            Item item1 = new(ItemName.apple, 60);
            Item item2 = new(ItemName.milk, 25);

            ItemOrder Order1 = new ItemOrder(item1, 2);
            ItemOrder Order2 = new ItemOrder(item2, 1);

            cart.AddItem(Order1);
            cart.AddItem(Order2);

            double TotalItem = cart.totalNumberOfItems();
            Assert.AreEqual(2, TotalItem, "Mismatch in Total Number of Purchased Item, Please check again");
        }

        [TestMethod()]
        public void should_checkout_cart()
        {
            Item item1 = new(ItemName.apple, 60);
            Item item2 = new(ItemName.milk, 25);
            Item item3 = new(ItemName.newspaper, 3);

            ItemOrder Order1 = new ItemOrder(item1, 2);
            ItemOrder Order2 = new ItemOrder(item2, 1);
            ItemOrder Order3 = new ItemOrder(item3, 1);

            cart.AddItem(Order1);
            cart.AddItem(Order2);
            cart.AddItem(Order3);

            double TotalPrice = cart.totalPriceOfItemsPurchased();
            Assert.AreEqual(148, TotalPrice, "Mismatch in TotalCost of Purchase, Please check again");

            cart.pay(new eWallet("sandhya@mail.com", "Password"));
        }

        [TestMethod()]
        public void should_remove_item_from_cart()
        {
            Item item1 = new(ItemName.apple, 60);
            Item item2 = new(ItemName.milk, 25);


            ItemOrder Order1 = new ItemOrder(item1, 2);
            ItemOrder Order2 = new ItemOrder(item2, 1);


            cart.AddItem(Order1);
            cart.AddItem(Order2);

            double TotalPrice = cart.totalPriceOfItemsPurchased();
            Assert.AreEqual(145, TotalPrice, "Mismatch in TotalCost of Purchase, Please check again");
            
            cart.removeItem(Order2);

            double TotalPriceAfterRemovingItem = cart.totalPriceOfItemsPurchased();
            Assert.AreEqual(120, TotalPriceAfterRemovingItem, "Mismatch in TotalCost of Purchase, Please check again");

            cart.pay(new eWallet("sandhya@mail.com", "Password"));
        }
    }
}