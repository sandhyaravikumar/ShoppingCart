namespace ShoppingCartApp
{
    public interface IProduct
    {
        int GetQuantity();

        double GetPrice();

        string GetName();
    }
}