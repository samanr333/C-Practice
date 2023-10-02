namespace EventsandDelegates
{
    public delegate void Calculation(double a, double b);
    public delegate void Calculation1(double x);
    internal class Program
    {
        static bool isUpperCase(string x)
        {
            return x.Equals(x.ToUpper());
        }
        static bool isEven(double z)
        {
            return z % 2 == 0;
        }
        static void greet(string name)
        {
            Console.WriteLine($"Hello, Good morning {name}");
        }
        static double sum(double a, double b)
        {
            return a + b;
        }
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

            // Func Delegate
            Console.WriteLine("Func Delegate: ");
            Console.WriteLine("Enter two numbers.");
            double p = double.Parse(Console.ReadLine());
            double q = double.Parse(Console.ReadLine());

            Func<double, double, double> add = sum;
            var result = add(p, q);
            Console.WriteLine("The sum of {0} and {1} is {2} ", p, q, result);
            // To check if the sum in Func delegate is true using predicate delegate
            Predicate<double> isEvenNum = isEven;
            Console.WriteLine($"The sum is even: {isEvenNum(result)}");


            // Action Delegates
            Console.WriteLine("Action Delegate: ");
            Console.WriteLine("Enter your name.");
            string name = Console.ReadLine();
            Action<string> greetMe = greet;
            greetMe(name);

            //Predicate Delegates
            Console.WriteLine("Predicate Delegate:");
            Predicate<string> upperCase = isUpperCase;
            bool res = upperCase(name);
            Console.WriteLine($"Is uppercase: {res}");

        }
    }
}