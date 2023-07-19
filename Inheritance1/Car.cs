using Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    public class Car: Vehicle
    {
         private string model;

        public Car(string brand, string model) : base(brand)
        {
            this.model = model;
            Console.WriteLine("This is a Car.");
        }

        public override void displayInfo()
        {
            base.displayInfo();
            Console.WriteLine("Model: " + model);
        }
    }
}
