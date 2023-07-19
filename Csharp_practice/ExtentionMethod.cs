using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_practice
{
    public static class Check
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }
    }
    public static class Capitalize
    {
        public static string StringCap(this string input)
        {
            if(string.IsNullOrEmpty(input)) 
                return input;
            return input.ToUpper();
        }
    }
    internal class ExtentionMethod
    {
        static void Main(string[] args)
        {
            int number1 = 41;
            int number2 = 56;

            Console.WriteLine($"{number1} is even: {number1.IsEven()}");
            Console.WriteLine($"{number1} is odd: {number1.IsOdd()}");
            Console.WriteLine($"{number2} is even: {number2.IsEven()}");
            Console.WriteLine($"{number2} is odd: {number2.IsOdd()}");

            //String capitalizer
            string name = "Zlatan";
            string name1 = name.StringCap();
            Console.WriteLine($"Before capitalizing: {name}");
            Console.WriteLine($"After capitalizing: {name1}");
        }
    }    
}
