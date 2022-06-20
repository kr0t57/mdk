using System;

namespace Task1
{
    internal sealed class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
            Console.WriteLine(Pow(2, 4));
            Console.WriteLine(FastPow(2, 4));
        }

        private static int Factorial(int n)
        {
            if (n < 0)
            {
                return -1;
            }
            if (n <= 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        private static double Pow(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n > 0)
            {
                return x * Pow(x, n - 1);
            }
            return 1 / Pow(x, -n);
        }

        private static double FastPow(double x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n % 2 == 0)
            {
                double res = FastPow(x, n >> 1);
                return res * res;
            }
            return x * FastPow(x, n - 1);
        }
    }
}
