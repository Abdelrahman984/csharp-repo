using System;
using System.Security.AccessControl;

namespace OOP
{
    class Program
    {
        public static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Oldsmobile";
            myCar.Color = "White";
            
            Console.WriteLine("{0} {1}", 
                myCar.Make,
                myCar.Color);
        }
    };

    class Car
    {
        // Type (prop) and tabtab for fast typing
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }
}

