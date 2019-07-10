using System;

namespace urban_planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building myHouse = new Building("2113 Old Greenbrier Pike", "Addam's Home"){
                Width = 500,
                Depth = 500,
                Stories = 27,
            };
            myHouse.Construct();
            myHouse.Purchase("Addam Joor");
            myHouse.Info();

            City nashville = new City("Nashville", "Some white dude", 1799);
            nashville.ConstructNewBuilding(myHouse);
            nashville.Info();
        }
    }
}
