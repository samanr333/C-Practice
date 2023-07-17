using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_practice
{
    internal class ArrayandList
    {
        static void Main(string[] args)
        {
            List<string> bikes = new List<string> { "Ducati", "Yamaha", "MV Agusta", "Kawasaki" };
            List<string> cars = new List<string> { "Lamborghini", "Mercedes", "Rolls Royace", "Bugatti" };
            List<int> nums = new List<int> { 17, 333, 18, 45, 15 };
            foreach(string bike in bikes)
            {
                Console.Write(bike + ", ");
            }
            Console.Write("\n");
            foreach(int num in nums)
            {
                Console.Write(num + ", ");
            }
            // Adding elements to the list
            bikes.Add("Harley Davidson");
            nums.Add(29);
            // After adding elements to the list
            Console.WriteLine("\n\nAfter adding to the list:");
            foreach (string bike in bikes)
            {
                Console.Write(bike + ", ");
            }
            Console.Write("\n");
            foreach (int num in nums)
            {
                Console.Write(num + ", ");
            }
            //Adding list to list
            cars.AddRange(bikes);
            Console.WriteLine("\n\nAfter adding to the list:");
            foreach (string car in cars)
            {
                Console.Write(car + ", ");
            }
        }
    }
}
