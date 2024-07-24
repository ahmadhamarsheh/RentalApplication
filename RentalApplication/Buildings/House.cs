
namespace RentalApplication.Buildings
{
    public class House : Building
    {
        public double GardenSize { get; set; }
        public House(string Address, string Name, double Size, Owner Owner, double GardenSize) : base(Address, Name, Size, Owner)
        {
            this.GardenSize = GardenSize;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"House: {Name}, Address: {Address}, Size: {Size} sqm, Owner : {Owner.Name}, Garden Size: {GardenSize} sqm");
        }
    }
}
