public interface IPaymentProcessor
{
    void ProcessPayment(double amount, string reference);
}