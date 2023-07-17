/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_practice
{
    internal class Loops
    {
        static void Main(String[] args)
        {
            //Loops in C#
            string[] cars = { "Mercedes", "Lamborghini", "Bugatti", "Mclaren" };
            //For Loop
            Console.WriteLine("Using for loop");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.Write(cars[i] + " ");
            }
            //While loop
            Console.WriteLine("\n\nUsing while loop");
            int j = 0;
            while (j < cars.Length)
            {
                Console.Write(cars[j] + " ");
                j++;
            }
            //Foreach loop
            Console.WriteLine("\n\nUsing foreach loop");
            foreach (string car in cars)
            {
                Console.Write(car + " ");
            }
            //Break statement
            Console.WriteLine("\n\nUsing break statement");
            for (int i = 0; i < cars.Length; i++)
            {
                if (i == 2)
                {
                    break;
                }
                Console.Write(cars[i] + " ");
            }
            //Continue statement
            Console.WriteLine("\n\nUsing continue statement");
            for (int i = 0; i < cars.Length; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                Console.Write(cars[i] + " ");
            }
        }
    }
}
*/