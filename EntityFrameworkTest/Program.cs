using EntityFrameworkTest.EF;
using EntityFrameworkTest.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new CarsDBContext())
            {
                var car = new Car() { Brand = "Audi" };
                var driver1 = new Driver() { DriverID = 1, Name = "Bill" };
                car.CurrentDriver = driver1;
                var driver2 = new Driver() { DriverID = 1, Name = "Bill" };
                car.PreviousDriver = driver2;

                Debug.WriteLine("Check equality before saving to db");
                Debug.WriteLineIf(driver1.Equals(driver2), "driver1 and 2 are equal");
                Debug.WriteLineIf(driver1.GetHashCode() == driver2.GetHashCode(), "hashcodes are equal");
                Debug.WriteLine("Driver1 hash: {0}", driver1.GetHashCode());
                Debug.WriteLine("Driver2 hash: {0}", driver2.GetHashCode());

                ctx.Cars.Add(car);
                ctx.Drivers.Remove(driver2);
                ctx.SaveChanges();

                Debug.WriteLine("Check equality after saving to db");
                Debug.WriteLineIf(driver1.Equals(driver2), "driver1 and 2 are equal");
                Debug.WriteLineIf(driver1.GetHashCode() == driver2.GetHashCode(), "hashcodes are equal");
                Debug.WriteLine("Driver1 hash: {0}", driver1.GetHashCode());
                Debug.WriteLine("Driver2 hash: {0}", driver2.GetHashCode());
            }
        }
    }
}
