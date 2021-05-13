namespace ShoppingCartApp
{
    public interface IEWallet
    {
        double GetBalance();

        double AddAmount(double amount);

        double DeductAmount(double amount);
    }
}