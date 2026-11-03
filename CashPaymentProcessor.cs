public class CashPaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(double amount, string reference)
    {
        Console.WriteLine("Paid £" + amount.ToString("F2") + " in cash for " + reference);
    }
}