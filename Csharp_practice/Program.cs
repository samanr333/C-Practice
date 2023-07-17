namespace Csharp_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 5;
            //Floats are suffixed with f
            float b = 5.9f;
            char c = 's';
            double d = 333.33;
            //Decimal literals are suffixed with m.
            decimal e = 99.99m;
            DateTime todayDate = DateTime.Now;
            int? nullableInt = null;
            //Print output
            Console.WriteLine("Int a = " + a);
            Console.WriteLine("Float b = " + b);
            Console.WriteLine("Char c = " + c);
            Console.WriteLine("Double d = " + d);
            Console.WriteLine("Decimal e = " + e);
            Console.WriteLine("Datetime = " + todayDate);
            Console.WriteLine("Nullable = " + nullableInt);

            // Using if-else statement
            Console.WriteLine("Enter your age.");
            // Taking input from user
            int age = Console.Read();
            if (age < 5)
            {
                Console.WriteLine("You are a baby.");
            }
            else if (age < 19)
            {
                Console.WriteLine("You are a teenager.");
            }
            else if (age < 60)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior citizen.");
            }
        }
    }
}