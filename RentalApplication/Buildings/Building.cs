
namespace RentalApplication.Buildings
{
    public abstract class Building
    {
        public string Address { get; set; }
        public string Name { get; set; }
        public double Size { get; set; }

        public Building(string Address, string Name, double Size)
        {
            this.Address = Address;
            this.Name = Name;
            this.Size = Size;
        }

        public abstract void DisplayInfo();
    }
}
