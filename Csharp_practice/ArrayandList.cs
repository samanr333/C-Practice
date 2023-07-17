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
            List<string> cars = new List<string> { "Ducati", "Yamaha", "MV Agusta", "Kawasaki" };
            List<int> nums = new List<int> { 17, 333, 18, 45, 15 };
            foreach(string car in cars)
            {
                Console.Write(car + ", ");
            }
            Console.Write("\n");
            foreach(int num in nums)
            {
                Console.Write(num + ", ");
            }
            cars.Add("Harley Davidson");
            nums.Add(29);
            Console.WriteLine("\nAfter adding to the list:");
            foreach (string car in cars)
            {
                Console.Write(car + ", ");
            }
            Console.Write("\n");
            foreach (int num in nums)
            {
                Console.Write(num + ", ");
            }

        }
    }
}
