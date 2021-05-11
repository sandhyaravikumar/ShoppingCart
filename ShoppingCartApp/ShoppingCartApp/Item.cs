namespace ShoppingCartApp
{
    public enum ItemName
    {
        apple,
        milk,
        newspaper
    }

    public class Item
    {
        private ItemName name;
        private double price;

        public Item(ItemName name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public ItemName getName()
        {
            return name;
        }

        public double getPrice()
        {
            return price;
        }
    }
}