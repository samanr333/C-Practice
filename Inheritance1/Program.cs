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
            Console.WriteLine("This is a Car.");
        }

        public override void displayInfo()
        {
            base.displayInfo();
            Console.WriteLine("Model: " + model);
        }
    }
    // Using multilevel inheritance
    public class ElectricCar : Car
    {
        protected int range;

        public ElectricCar(string brand, string model, int range) : base(brand, model)
        {
            this.range = range;
        }

        public override void displayInfo()
        {
            base.displayInfo();
            Console.WriteLine("Range: " + range + " kWh");
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            // Single inheritance example
            Console.WriteLine("Single level inheritance");
            Car car = new Car("Bugatti", "Veyron");
            car.displayInfo();

            //Multi level inheritance
            Console.WriteLine("\nMulti level inheritance");
            ElectricCar electricCar = new ElectricCar("Tesla", "S", 663);
            electricCar.displayInfo();
        }
    }
}
