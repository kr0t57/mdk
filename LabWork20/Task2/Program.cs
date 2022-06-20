using System;

namespace Task2
{
    internal sealed class Program
    {
        private delegate void Operator(int value, int value2);

        private static void Main()
        {
            Operator operators = DisplaySum;
            operators += DisplaySubstract;
            operators += DisplayMultiply;
            operators += DisplayDivision;

            operators.Invoke(10, 10);
        }

        private static void DisplaySum(int value, int value2)
        {
            Console.WriteLine(value + value2);
        }

        private static void DisplaySubstract(int value, int value2)
        {
            Console.WriteLine(value - value2);
        }

        private static void DisplayMultiply(int value, int value2)
        {
            Console.WriteLine(value * value2);
        }

        private static void DisplayDivision(int value, int value2)
        {
            Console.WriteLine(value / value2);
        }
    }
}
