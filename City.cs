using System;
using System.Collections.Generic;

namespace urban_planner
{
    public class City 
    {
        public string CityName { get; set; }
        public string Mayor { get; set; }
        public int YearFounded { get; set; }
        public List<Building> BuildingsContained { get; set; }
        public City(string city, string mayor, int year)
        {
            CityName = city;
            Mayor = mayor;
            YearFounded = year;
            BuildingsContained = new List<Building>();
        }
        public void ConstructNewBuilding(Building BuildingName)
        {
            BuildingsContained.Add(BuildingName);
        }
        public void Info()
        {
            Console.WriteLine("");
            Console.WriteLine($"{CityName} was founded in {YearFounded}. The current mayor of {CityName} is {Mayor}.");
            Console.WriteLine("");
            foreach (Building building in BuildingsContained)
            {
                Console.WriteLine($"{building.name} is at some address.");
            }
        }
    }
}