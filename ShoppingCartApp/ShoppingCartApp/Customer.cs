namespace ShoppingCartApp
{
    public class Customer
    {
        private string name;
        private EWallet ewallet;
        private ShoppingCart cart;

        public Customer(string name, EWallet ewallet)
        {
            this.name = name;
            this.ewallet = ewallet;
            cart = new ShoppingCart();
        }

        public void AddToCart(IProduct product)
        {
            cart.AddProduct(product);
        }

        public void RemoveFromCart(IProduct product)
        {
            cart.RemoveProduct(product);
        }

        private double GetTotalPrice()
        {
            return cart.GetTotalPrice();
        }

        public double GetWalletBalance()
        {
            return ewallet.GetBalance();
        }

        public void PayFromEWallet()
        {
            ewallet.DeductAmount(GetTotalPrice());
            EmptyCart();
        }

        private void EmptyCart()
        {
            cart.EmptyCart();
        }
    }
}