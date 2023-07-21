namespace EventsandDelegates
{
    public delegate void Calculation(double a, double b);
    public delegate void Calculation1(double x);
    internal class Program
    {
        protected static void Add(double a, double b)
        {
            Console.WriteLine($"The sum is: {a + b}");
        }
        protected static void Subtract(double a, double b)
        {
            Console.WriteLine($"The difference is: {a - b}");
        }
        protected static void Multiplication(double a, double b)
        {
            Console.WriteLine($"The product is: {a * b}");
        }
        protected static void Division(double a, double b)
        {
            Console.WriteLine($"The quotient is: {a / b}");
        }
        protected static void Square(double x)
        {
            double square = x * x;
            Console.WriteLine("The square of {0} is {1}", x, square);
        }
        protected static void Cube(double x)
        {
            double cube = x * x * x;
            Console.WriteLine("The cube of {0} is {1}", x, cube);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Calculation calculation = new Calculation(Add);
            calculation(a, b);
            calculation = Subtract;
            calculation(a, b);
            calculation = Multiplication;
            calculation(a, b);
            calculation = Division;
            calculation(a, b);
            Console.WriteLine("Enter a number.");
            double x = double.Parse(Console.ReadLine());
            Calculation1 calculation1 = new Calculation1(Square);
            calculation1(x);
            calculation1 = Cube;
            calculation1(x);
            // Func delegate
            Console.WriteLine("Func Delegate: ");
            Func<double, double, double> add = Add;
            var result = add(a, b);
            Console.WriteLine("The sum of {0} and {1} is {2} ", p, q, result);

        }
    }
}