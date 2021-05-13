namespace ShoppingCartApp
{
    public interface IEWallet
    {
        double getBalance();

        double AddAmount(double amount);

        double DeductAmount(double amount);
    }
}