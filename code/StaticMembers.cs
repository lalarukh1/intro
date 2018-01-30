using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myapp{

    class Car1
    {
        public string Color { get; set; }
        public int Year { get; set; }

        public int Mileage { get; set; }
        private static int instances;
        public Car1 ()
        {
            instances ++;
        }

        public static int CountCars()
        {
            return instances;
        }
        
        public Car1 (String color, int year)
        {
            this.Color = color;
            this.Year = year;
            instances ++;
        }

        public Car1 (int year, int mileage)
        {
            this.Year = year;
            this.Mileage = mileage;
            instances ++;
        }

    }

    public class StaticMembers
    {
        public void usingCar()
        {
            var car2 = new Car1();
            car2.Color = "Yellow";
            car2.Year = 2011;
            car2.Mileage = 20000;
            var car3 = new Car1("orange", 2017);
            var car4 = new Car1(2016, 9000);
            // accessing static member
            int carCount = Car1.CountCars();
            Console.WriteLine($"There are {carCount} cars in inventory");

        }
    }
}