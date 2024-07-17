
namespace RentalApplication.Contracts
{
    public class Contract
    {
        public Customer Customer { get; set; }
        public Building Building { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public Contract(Customer Customer, Building Building, DateTime StartDate, DateTime EndDate, double Price)
        {
            this.Customer = Customer;
            this.Building = Building;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Price = Price;
        }
        public void DisplayContract()
        {
            Console.WriteLine($"Contract Details:\nCustomer: {Customer.Name}\nBuilding: {Building.Name}\nAddress: {Building.Address}\nSize: {Building.Size} sqm\nStart Date: {StartDate.ToShortDateString()}\nEnd Date: {EndDate.ToShortDateString()}\nPrice: ${Price}");
        }
    }
}
