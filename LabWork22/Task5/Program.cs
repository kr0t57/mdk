using System;

namespace Task5
{
    internal sealed class Program
    {
        private static void Main()
        {
            //Task 5.1
            Console.WriteLine("Task 5.1");
            int R = 5;
            int r = 3;

            double s = Math.PI * Math.Pow(R, 2) - Math.PI * Math.Pow(r, 2);
            double s2 = Math.PI * (R - r) * (R + r);

            Console.WriteLine(s);
            Console.WriteLine(s2);

            //Task 5.2
            Console.WriteLine("\nTask 5.2");
            int n = 9;

            int i, sum = 0;
            for (i = 1; i <= n; i++)
                sum += i;

            Console.WriteLine(sum);

            sum = (1 + n) * n / 2;

            Console.WriteLine(sum);
        }

        //Task 5.3
        private int Sum(int a, int b)
        {
            return a + b;
        }

    }
}
