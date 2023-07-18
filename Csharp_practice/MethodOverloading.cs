/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_practice
{
    internal class MethodOverloading
    {
        public class Calculator
        {
            public int add(int a, int b)
            {
                return a + b;
            }

            public double add(double a, double b)
            {
                return a + b;
            }

            public int add(int a, int b, int c)
            {
                return a + b + c;
            }
        }
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("The sum of 2 and 3 is " + calculator.add(2, 3));
            Console.WriteLine("The sum of 2.9 and 3.6 is " + calculator.add(2.9, 3.6));
            Console.WriteLine("The sum of 5, 2 and 3 is " + calculator.add(5, 2, 3));
        }
    }

}
*/