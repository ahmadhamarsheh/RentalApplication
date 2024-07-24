
namespace RentalApplication.Buildings
{
    public class Shop : Building
    {
        public string BusinessType { get; set; }
        public Shop(string Address, string Name, double Size, Owner Owner, string BusinessType) : base(Address, Name, Size, Owner)
        {
            this.BusinessType = BusinessType;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Shop: {Name}, Address: {Address}, Size: {Size} sqm, Owner : {Owner.Name}, Business Type: {BusinessType}");
        }
    }
}
