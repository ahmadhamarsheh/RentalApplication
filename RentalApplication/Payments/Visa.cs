
namespace RentalApplication.Payments
{
    public class Visa : IPaymentMethod
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing Visa payment of ${amount}");
        }
    }
}
