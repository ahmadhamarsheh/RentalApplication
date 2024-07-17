
namespace RentalApplication.Payments
{
    public class MasterCard : IPaymentMethod
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing MasterCard payment of ${amount}");
        }
    }
}
