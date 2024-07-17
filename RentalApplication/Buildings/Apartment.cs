
namespace RentalApplication.Buildings
{
    public class Apartment : Building
    {
        public int Floor { get; set; }
        public Apartment(string Address, string Name, double Size, int Floor) : base(Address, Name, Size)
        {
            this.Floor = Floor;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Apartment: {Name}, Address: {Address}, Size: {Size} sqm, Floor: {Floor}");
        }
    }
}
