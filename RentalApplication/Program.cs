
namespace RentalApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            var owner1 = new Owner("Amin Eid");
            var owner2 = new Owner("Ahmad Hamarsheh");

            var apartment = new Apartment("100 Abu Baker St", "Jenin Apartment", 75, owner1, 3);
            var house = new House("200 Ninty St", "Haifa Cottage", 120, owner2, 30);
            var shop = new Shop("300 Toot St", "Mini Market", 50, owner2, "Retail");

            owner1.AddBuilding(apartment);
            owner2.AddBuilding(house);
            owner2.AddBuilding(shop);
            PrintSeparator();

            owner1.DisplayOwnedBuilding();
            owner2.DisplayOwnedBuilding();
            PrintSeparator();

            var customer = new Customer("Aseel Issa");

            customer.RentBuilding(apartment);
            customer.RentBuilding(house);
            customer.RentBuilding(shop);
            PrintSeparator();

            customer.DisplayRentedBuildings();
            PrintSeparator();

            var contract1 = new Contract(customer, apartment, DateTime.Now, DateTime.Now.AddMonths(24), 260000 , owner1);
            contract1.DisplayContract();
            PrintSeparator();
            var contract2 = new Contract(customer, house, DateTime.Now, DateTime.Now.AddMonths(12), 120000, owner2);
            contract2.DisplayContract();
            PrintSeparator();
            var contract3 = new Contract(customer, shop, DateTime.Now, DateTime.Now.AddMonths(18), 84000, owner2);
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