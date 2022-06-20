using System;

namespace Task1
{
    internal sealed class Program
    {
        private static void Main()
        {
            Console.Write("Введите N: ");
            Int32.TryParse(Console.ReadLine(), out int n);
            Console.WriteLine(Factorial(n));
        }

        private static int Factorial(int n)
        {
            int result = 1;

            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
