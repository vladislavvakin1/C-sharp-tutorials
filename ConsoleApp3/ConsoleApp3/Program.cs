using System;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "SuperVolkswagen";
            myCar.Model = "Atreon";
            myCar.Year = 2020;
            myCar.Color = "Silver";

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);
            
            Console.WriteLine("{0:C}", myCar.DetermineCarValue());
            
        }
        private static decimal DetermineCarValue(Car car)
        {
            decimal value = 100.0M;
            return value;
        }
        class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }

            public decimal DetermineCarValue()
            {
                decimal carValue;

                if (Year > 1980)
                {
                    carValue = 10000;
                }
                else
                {
                    carValue = 2000;
                }
                return carValue;
            }
        }
    }
}
