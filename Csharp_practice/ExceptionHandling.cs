/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_practice
{
    internal class ExceptionHandling
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers.");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            try
            {
                double division = a / b;
                if (b==0)
                {
                    throw new DivideByZeroException("Error");
                }
                else
                {
                    Console.WriteLine($"The output is {division}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured: " + e.Message);
            }
            finally
            {
                Console.WriteLine($"Exception handled");
            }

        }
    }
}
*/