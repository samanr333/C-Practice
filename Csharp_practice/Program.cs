namespace Csharp_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Datatypes in C#
            /*int a = 5;
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
            Console.WriteLine("Nullable = " + nullableInt);*/

            // Using if-else statement
            /*Console.WriteLine("Enter your age.");
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
            }*/

            //Switch statement 
            /* Console.WriteLine("Enter the day number.");
             int dayOfWeek = int.Parse(Console.ReadLine());

             switch (dayOfWeek)
             {
                 case 1:
                     Console.WriteLine("It's Sunday!");
                     break;
                 case 2:
                     Console.WriteLine("It's Monday!");
                     break;
                 case 3:
                     Console.WriteLine("It's Tuesday!");
                     break;
                 case 4:
                     Console.WriteLine("It's Wednesday!");
                     break;
                 case 5:
                     Console.WriteLine("It's Thursday!");
                     break;
                 case 6:
                     Console.WriteLine("It's Friday!");
                     break;
                 case 7:
                     Console.WriteLine("It's Saturday!");
                     break;

                 default:
                     Console.WriteLine("Invalid!");
                     break;
             }*/

            //Loops in C#
            string[] cars = { "Mercedes", "Lamborghini", "Bugatti", "Mclaren" };
            //For Loop
            Console.WriteLine("Using for loop");
            for(int i=0; i < cars.Length; i++)
            {
                Console.Write(cars[i] + " ");
            }
            Console.WriteLine("\n\nUsing while loop");
            int j = 0;
            while(j < cars.Length)
            {
                Console.Write(cars[j] + " ");
                j++;
            }
            Console.WriteLine("\n\nUsing foreach loop");
            foreach(string car in cars)
            {
                Console.Write(car + " ");
            }
            Console.WriteLine("\n\nUsing break statement");
            for (int i = 0; i < cars.Length; i++)
            {
                if (i == 2)
                {
                    break;
                }
                Console.Write(cars[i] + " ");
            }
            Console.WriteLine("\n\nUsing continue statement");
            for (int i = 0; i < cars.Length; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                Console.Write(cars[i] + " ");
            }
        }
    }
}