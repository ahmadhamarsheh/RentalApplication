using System;
using System.Collections.Generic;
using System.Linq;

namespace RentalApplication.People
{
    public class Customer : Person
    {
        public List<Building> RentedBuildings { get; set; }
        public Customer(string Name) : base(Name)
        {
            RentedBuildings = new List<Building>();
        }
        public void RentBuilding(Building building)
        {
            RentedBuildings.Add(building);
            Console.WriteLine($"{Name} has rented {building.Name}");
        }
        public void DisplayRentedBuildings()
        {
            Console.WriteLine($"{Name} has rented the following buildings:");
            foreach (var building in RentedBuildings)
            {
                building.DisplayInfo();
            }
        }
    }
}
