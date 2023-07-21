namespace EventsandDelegates
{
    internal class Program
    {
        public delegate void Calculation(double a, double b);
        public static void Add(double a, double b)
        {
            Console.WriteLine($"The sum is: {a + b}");
        }
        public static void Subtract(double a, double b)
        {
            Console.WriteLine($"The difference is: {a - b}");
        }
        public static void Multiplication(double a, double b)
        {
            Console.WriteLine($"The product is: {a * b}");
        }
        public static void Division(double a, double b)
        {
            Console.WriteLine($"The quotient is: {a / b}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Calculation calculation = new Calculation(Program.Add);
            calculation(a, b);
            calculation = Subtract;
            calculation(a, b);
            calculation = Multiplication;
            calculation(a, b);
            calculation = Division;
            calculation(a, b);
        }
    }
}