using System;

namespace urban_planner
{
    public class Building
    {
        private string _designer { get; set; }
        private DateTime _dateConstructed { get; set; }
        private string _address { get; set; }
        private string _owner { get; set; }
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
        public Building(string address) 
        {
            _address = address;
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
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
        }

    }
}