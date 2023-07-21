/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsandDelegates
{
    public delegate void Calculation(double a, double b);
    internal class MultiCast
    {
        protected static void Add(double a, double b)
        {
            Console.WriteLine($"The sum is: {a + b}");
        }
        protected static void Subtract(double a, double b)
        {
            Console.WriteLine($"The difference is: {a - b}");
        }
        protected static void Multiplication(double a, double b)
        {
            Console.WriteLine($"The product is: {a * b}");
        }
        protected static void Division(double a, double b)
        {
            Console.WriteLine($"The quotient is: {a / b}");
        }
        protected static void Square(double x)
        {
            double square = x * x;
            Console.WriteLine("The square of {0} is {1}", x, square);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Calculation calculation = new Calculation(Add);
            calculation += Subtract;
            calculation += Multiplication;
            calculation += Division;
            calculation(a, b);
        }
    }
}
*/