using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_practice
{
    class Info
    {
        private static string name;

        public static string Name
        {
            get { return name; }
            set { name = value; }
        }
        public static void getName(string name)
        {
            Console.WriteLine($"My name is {name}");
        }
    }
    internal class StaticModifier
    {
        static void Main(string[] args)
        {
            Info.Name = "Ram";
            Console.WriteLine(Info.Name);
            Info.getName("saman");
        }
    }
}
