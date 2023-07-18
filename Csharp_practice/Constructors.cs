using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_practice
{
    public class AthleatInfo
    {
        public string Name;
        public int Age;
        public string Sports;
        //Default Constructor
        public AthleatInfo()
        {
            Name = "AB De Villiers";
            Age = 39;
            Sports = "Cricket";
        }
        //Parameterized Constructor
        public AthleatInfo(string name, int age, string sports)
        {
            Name = name;
            Age = age;
            Sports = sports;
        }
    }
    internal class Constructors
    {
        static void Main(string[] args)
        {
            AthleatInfo athleat1 = new AthleatInfo();
            Console.WriteLine("\nInfo of first Athleat: ");
            Console.WriteLine("Name: " + athleat1.Name + " Age: " + athleat1.Age + " Sports: " + athleat1.Sports);

            AthleatInfo athleat2 = new AthleatInfo("Lewis Hamilton", 38, "F1");
            Console.WriteLine("\nInfo of second Athleat: ");
            Console.WriteLine("Name: " + athleat2.Name + " Age: " + athleat2.Age + " Sports: " + athleat2.Sports);

        }
    }
}
