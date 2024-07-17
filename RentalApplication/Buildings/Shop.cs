
namespace RentalApplication.Buildings
{
    public class Shop : Building
    {
        public string BusinessType { get; set; }
        public Shop(string Address, string Name, double Size, string BusinessType) : base(Address, Name, Size)
        {
            this.BusinessType = BusinessType;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Shop: {Name}, Address: {Address}, Size: {Size} sqm, Business Type: {BusinessType}");
        }
    }
}
