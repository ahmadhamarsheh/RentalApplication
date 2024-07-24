
namespace RentalApplication.Buildings
{
    public class Apartment : Building
    {
        public int Floor { get; set; }
        public Apartment(string Address, string Name, double Size, Owner Owner, int Floor) : base(Address, Name, Size, Owner)
        {
            this.Floor = Floor;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Apartment: {Name}, Address: {Address}, Size: {Size} sqm, Owner : {Owner.Name}, Floor: {Floor}");
        }
    }
}
