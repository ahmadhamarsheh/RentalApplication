
namespace RentalApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            var apartment = new Apartment("100 Abu Baker St", "Jenin Apartment", 75, 3);
            var house = new House("200 Ninty St", "Haifa Cottage", 120, 30);
            var shop = new Shop("300 Toot St", "Mini Market", 50, "Retail");
            PrintSeparator();

            var customer = new Customer("Aseel Issa");

            customer.RentBuilding(apartment);
            customer.RentBuilding(house);
            customer.RentBuilding(shop);
            PrintSeparator();

            customer.DisplayRentedBuildings();
            PrintSeparator();

            var contract1 = new Contract(customer, apartment, DateTime.Now, DateTime.Now.AddMonths(24), 260000);
            contract1.DisplayContract();
            PrintSeparator();
            var contract2 = new Contract(customer, house, DateTime.Now, DateTime.Now.AddMonths(12), 120000);
            contract2.DisplayContract();
            PrintSeparator();
            var contract3 = new Contract(customer, shop, DateTime.Now, DateTime.Now.AddMonths(18), 84000);
            contract3.DisplayContract();
            PrintSeparator();
            IPaymentMethod paymentMethod = new PayPal();
            paymentMethod.ProcessPayment(260000);
            PrintSeparator();
            paymentMethod = new Visa();
            paymentMethod.ProcessPayment(120000);
            PrintSeparator();
            paymentMethod = new MasterCard();
            paymentMethod.ProcessPayment(84000);
            PrintSeparator();
        }

        static void PrintSeparator()
        {
            Console.WriteLine(new string('=', 50));
        }
    }
}