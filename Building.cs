using System;

namespace urban_planner
{
    public class Building
    {
        public string name {get; set;}
        private string _designer = "Addam Joor";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume 
        { 
            get 
            {
                return Width * Depth * (3*Stories);
            } 
        }
        public Building(string address, string buildingName) 
        {
            _address = address;
            name = buildingName;
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }
        public void Purchase(string nameOfBuyer)
        {
            _owner = nameOfBuyer;
        }

        public void Info()
        {
            Console.WriteLine("");
            Console.WriteLine(_address);
            Console.WriteLine("--------------------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
        }
    }
}