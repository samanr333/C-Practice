namespace Interface
{
    interface Ivehicle
    {
        public void vehicleDetails();
    }
    interface Ispeed
    {
        public void speedDetails();
    }
    public class Car: Ivehicle, Ispeed
    {
        public void vehicleDetails()
        {
            Console.WriteLine("This is a Car");
        }
        public void speedDetails()
        {
            Console.WriteLine("I am fast");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car= new Car();
            car.vehicleDetails();
            car.speedDetails();
        }
    }
}