namespace ShoppingCartApp
{
    public class ItemOrder
    {
        private Item items;
        private int quantity;

        public ItemOrder(Item items, int quantity)
        {
            this.items = items;
            this.quantity = quantity;
        }

        public Item getitem()
        {
            return items;
        }

        public int getQuantity()
        {
            return quantity;
        }

        public double TotalCost()
        {
            double total = items.getPrice() * getQuantity();
            return total;
        }
    }
}