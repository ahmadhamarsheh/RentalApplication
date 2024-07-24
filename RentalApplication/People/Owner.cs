using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalApplication.People
{
    public class Owner : Person
    {
        public List<Building> OwnedBuildings { get; set; }
        public Owner(string name) : base(name)
        {
            OwnedBuildings = new List<Building>();
        }

        public void AddBuilding(Building building)
        {
            OwnedBuildings.Add(building);
        }

        public void DisplayOwnedBuilding()
        {
            Console.WriteLine($"{Name} owns the following building:");
            foreach (var building in OwnedBuildings)
            {
                building.DisplayInfo();
            }
        }
    }
}
