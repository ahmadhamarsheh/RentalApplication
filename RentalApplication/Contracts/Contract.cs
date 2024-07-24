namespace RentalApplication.Contracts
{
    public class Contract
    {
        public Customer Customer { get; set; }
        public Owner Owner { get; set; }
        public Building Building { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public Contract(Customer Customer, Building Building, DateTime StartDate, DateTime EndDate, double Price, Owner Owner)
        {
            this.Customer = Customer;
            this.Building = Building;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Price = Price;
            this.Owner = Owner;
        }
        public void DisplayContract()
        {
            Console.WriteLine($"{Customer.Name} rented {Building.Name} from {Owner.Name}.");
            Console.WriteLine($"Contract Details:\nCustomer: {Customer.Name}\nBuilding: {Building.Name}\nAddress: {Building.Address}\nSize: {Building.Size} sqm\nStart Date: {StartDate.ToShortDateString()}\nEnd Date: {EndDate.ToShortDateString()}\nPrice: ${Price}");
        }
    }
}
