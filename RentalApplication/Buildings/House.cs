
namespace RentalApplication.Buildings
{
    public class House : Building
    {
        public double GardenSize { get; set; }
        public House(string Address, string Name, double Size, double GardenSize) : base(Address, Name, Size)
        {
            this.GardenSize = GardenSize;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"House: {Name}, Address: {Address}, Size: {Size} sqm, Garden Size: {GardenSize} sqm");
        }
    }
}
