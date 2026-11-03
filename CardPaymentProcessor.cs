public class CardPaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(double amount, string reference)
    {
        Console.WriteLine("Paid £" + amount.ToString("F2") + " by card for " + reference);
    }
}