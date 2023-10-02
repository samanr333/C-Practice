/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsandDelegates
{
    public delegate void SingleCastDelegate(string name);
    internal class SingleCast
    {
        protected static void Greet(string name)
        {
            Console.WriteLine($"Hello, Good morning {name}!");
        }
        static void Main(string[] args)
        {
            SingleCastDelegate n = new SingleCastDelegate(Greet);
            Console.WriteLine("Enter your name.");
            var name = Console.ReadLine();
            n(name);
        }
    }
}
*/