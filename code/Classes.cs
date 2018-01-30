using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myapp
{
     
    public class Car 
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
    }

    public class Classes {

        public void usingCar()
       {
           var Car1 = new Car();
           Car1.Color = "Red";
           Car1.Year = 2010;
           Car1.Mileage = 10000;
           Console.WriteLine($"This car has {Car1.Color} color, was made in {Car1.Year}, has {Car1.Mileage} miles");
       }

    }
    
}