using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SynchronousAndAsynchronous
{
    internal class Synchronous
    {
        public static void Task1()
        {
            Console.WriteLine("Task 1 Started");
            Thread.Sleep(2000);
            Console.WriteLine("Task 1 completed");
        }
        public static void Task2()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Task 2 Started");
            Thread.Sleep(2000);
            Console.WriteLine("Task 2 completed");
        }
        public static void Main(string[] args)
        {
            Task1();
            Task2();
        }
    }
}
