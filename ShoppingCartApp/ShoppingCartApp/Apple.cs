namespace ShoppingCartApp
{
    public class Apple : IProduct
    {
        public enum Categories
        {
            GrannySmithApple,
            RedApple,
            CameoApple,
        }

        private string name;

        private double price;

        private Categories type;

        private int quantity;

        public Apple(string name, Categories type, double price, int quantity)
        {
            this.price = price;
            this.name = name;
            this.type = type;
            this.quantity = quantity;
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