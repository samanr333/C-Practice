using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynchronousAndAsynchronous
{
    internal class Asynchronous
    {
        public static async void Task1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 1 Started");
                Thread.Sleep(2000);
                Console.WriteLine("Task 1 completed");
            });
        }
        public static async void Task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 2 Started");
                Thread.Sleep(4000);
                Console.WriteLine("Task 2 completed");
            });
        }
        public static async void Task3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 3 Started");
                Thread.Sleep(1000);
                Console.WriteLine("Task 3 completed");
            });
        }
        public static async void Task4()
        {
            Console.WriteLine("Task 4 Started");
            await Task.Delay(3000);
            Console.WriteLine("Task 4 completed");
            /*await Task.Run(() =>
            {
                Console.WriteLine("Task 4 Started");
                Thread.Sleep(3000);
                Console.WriteLine("Task 4 completed");
            });*/
        }
        public static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Console.ReadLine();
        }
    }
}
