namespace PR11
{
    internal class Program
    {
        private static int _balance;

        private static void Main(string[] args)
        {
            Deposit(1000);
            GetBalance();
            Withdraw(500);
            Withdraw(600);
            GetBalance();

        }

        private static void PrintHello()
        {
            Console.WriteLine("Privet");
        }

        private static int Add(int a, int b) => a + b;

        private static bool IsEven(int a) => (a % 2 == 0);

        private static void Swap(ref int a, ref int b) => (a, b) = (b, a);

        private static double Divide(int a, int b, out int ost)
        {
            ost = a % b;
            return a / (double)b;
        }

        private static int Multiply(int a, int b) => a * b;

        private static int Multiply(int a, int b, int c) => a * b * c;

        private static double Multiply(double a, double b) => a * b;

        private static int Fact(int a) => a > 1 ? a * Fact(a - 1) : 1;

        private static int Fibonacci(int n)
        {
            return (n < 2) ? n : Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        private static int Sum(params int[] n) => n.Aggregate((a, b) => a + b);

        private static int Min(params int[] n) => n.Min();

        private static void Deposit(int n)
        {
            _balance += n;

            Console.WriteLine($"Balance: +{n}");
        }

        private static void Withdraw(int n)
        {
            if (n <= _balance)
            {
                _balance -= n;
                Console.WriteLine($"Balance: -{n}");
            }
            else
                Console.WriteLine($"Недостаточно средств для вывода {n}");
        }

        private static void GetBalance() => Console.WriteLine($"Balance: {_balance}");
    }
}