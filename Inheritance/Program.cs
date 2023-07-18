using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

namespace Inheritance
{
    // This is base class
    public class Vehicle
    {
        protected string brand;

        public Vehicle(string brand)
        {
            this.brand = brand;
        }

        public virtual void displayInfo()
        {
            Console.WriteLine("Brand: " + brand);
        }
    }

    // Using single inheritance
    public class Car : Vehicle
    {
        protected string model;

        public Car(string brand, string model) : base(brand)
        {
            this.model = model;
        }

        public override void displayInfo()
        {
            Console.WriteLine("This is a Car: ");
            base.displayInfo();
            Console.WriteLine("Model: " + model);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Single inheritance example
            Car car = new Car("Bugatti", "Veyron");
            car.displayInfo();
            Console.WriteLine();
        }
    }
}