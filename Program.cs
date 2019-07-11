using System;

namespace urban_planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building NashvilleSoftwareSchool = new Building("500 Interstate Blvd", "NSS"){
                Width = 500,
                Depth = 500,
                Stories = 27,
            };
            NashvilleSoftwareSchool.Construct();
            NashvilleSoftwareSchool.Purchase("John Wark");
            NashvilleSoftwareSchool.Info();

            Building Home = new Building("1537 Mohawk Trail", "My house"){
                Width = 50,
                Depth = 50,
                Stories = 2,
            };
            Home.Construct();
            Home.Purchase("Addam Joor");
            Home.Info();

            Building MomsHouse = new Building("2113 Old Greenbrier Pike", "My mom's house"){
                Width = 50,
                Depth = 50,
                Stories = 1,
            };
            MomsHouse.Construct();
            MomsHouse.Purchase("William Joor");
            MomsHouse.Info();

            City nashville = new City("Nashville", "David Briley", 1806);
            nashville.ConstructNewBuilding(NashvilleSoftwareSchool);
            nashville.ConstructNewBuilding(Home);
            nashville.ConstructNewBuilding(MomsHouse);
            nashville.Info();
        }
    }
}
