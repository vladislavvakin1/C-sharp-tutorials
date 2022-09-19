using System;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car = new Car();
            car.Make = "Volkswagen";
            car.Year = 2008;
            car.Color = "Grey";
            car.Model = "A";
            car.VIN = "A1";
            

            Car car2 = new Car();
            car2.Make = "BMW";
            car2.Year = 2010;
            car2.Color = "Gray";
            car2.Model = "B";
            car2.VIN = "B1";


            Book book = new Book();
            book.Title = "C# Fundumentals in 1 year";
            book.Author = "James Tabor";
            */

            /* 
            List<Car> cars = new List<Car>();
            cars.Add(car);
            cars.Add(car2);

            foreach (Car acar in cars)
            {
                Console.WriteLine($"We have a {acar.Color} {acar.Make} {acar.Model} of {acar.Year}.");
            }
            */

            /*
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car.VIN, car);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["A1"].Color);

            */

            //Object initializer
            //No need of Constructor
            Car car1 = new Car() { Make = "BMW", Model = "750li", VIN = "C3"};
            Car car2 = new Car() { Make = "Toyota", Model = "4Runner", VIN = "D4" };

            //Collection initializer
            //The question is why do not we need a variable to store class's info in 
            List<Car> myList = new List<Car> { 
                new Car {Make = "Oldsmobile", Model = "Cutlas Supreme", VIN = "E5"},
                new Car {Make = "Nissan", Model = "Altima", VIN = "F6"}
                };
            Console.WriteLine(myList[1].Make);
        }

        class Car
        {
            public string Make { get; set; }
            public int Year { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public string VIN { get; set; }
        }

        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
        }
    }
}
