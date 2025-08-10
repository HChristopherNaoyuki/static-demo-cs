using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace static_demo_cs
{
    class Solution
    {
        public Solution()
        {
            // Constructor body can be left empty or used to initialize things
        }

        public void Run()
        {
            // Create two Car objects with make, model, year, and color using constructor
            Car Car1 = new Car("Ford", "F-150", 2022, "Red");
            Car1.Drive();

            Car Car2 = new Car("Chevy", "Corvette", 2021, "Blue");
            Car2.Drive();

            Console.WriteLine($"NUMBER OF CARS: {Car.Number_of_cars}");
        }
    }

    // Car class with properties and behavior
    public class Car
    {
        public String Make;
        public String Model;
        public int Year;
        public String Color;
        public static int Number_of_cars;

        // Constructor to initialize Car object
        public Car(String Make, String Model, int Year, String Color)
        {
            try
            {
                // Assign constructor parameters to class fields
                this.Make = Make;
                this.Model = Model;
                this.Year = Year;
                this.Color = Color;

                Number_of_cars = Number_of_cars + 1;
            }
            catch (Exception Issue)
            {
                // Catch any assignment errors (unlikely in this case)
                Console.WriteLine($"[ERROR]: {Issue.Message}");
            }
        }

        // Simulates driving the car
        public void Drive()
        {
            try
            {
                Console.WriteLine($"MAKE: {Make}");
                Console.WriteLine($"MODEL: {Model} \n");
            }
            catch (Exception Issue)
            {
                // Catch unexpected issues during Drive (e.g., null properties)
                Console.WriteLine($"[ERROR]: {Issue.Message}");
            }
        }
    }
}
