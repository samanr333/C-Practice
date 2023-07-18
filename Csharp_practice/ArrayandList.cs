/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_practice
{
    internal class ArrayandList
    {
        //Defining list of object
        public class Info
        {
            public string name { get; set; }
            public int age { get; set; }
        }
        static void Main(string[] args)
        {
            List<string> bikes = new List<string> { "Ducati", "Yamaha", "MV Agusta", "Kawasaki" };
            List<string> cars = new List<string> { "Lamborghini", "Mercedes", "Rolls Royace", "Bugatti" };
            List<int> nums = new List<int> { 2, 6, 14, 24, 17, 18, 45, 15 };
            foreach (string bike in bikes)
            {
                Console.Write(bike + ", ");
            }
            Console.Write("\n");
            foreach (int num in nums)
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
            //Finding elements in the list
            int number = nums.Find(n => n > 20);
            Console.Write("\n\nElements in nums that are greater than 40: " + number);

            //List of Objects
            Console.WriteLine("\n\nList of objects:");
            List<Info> players = new List<Info>();
            players.Add(new Info { name = "AB De Villiers", age = 39 });
            players.Add(new Info { name = "Virat Kohli", age = 34 });

            foreach (Info player in players)
            {
                Console.WriteLine("Name: " + player.name + ", " + "Age: " + player.age);
            }

        }
    }
}
*/