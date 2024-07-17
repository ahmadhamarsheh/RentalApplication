
namespace RentalApplication.Payments
{
    public class PayPal : IPaymentMethod
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing PayPal payment of ${amount}");
        }
    }
}
