using System;
using System.Linq;
using System.Collections.Generic;

namespace Task3
{
    internal sealed class Program
    {
        private static void Main()
        {
            List<string> currencies = new List<string> { "ruble", "dollar", "euro" };

            Console.WriteLine("Введите startIndex:");
            Int32.TryParse(Console.ReadLine(), out int startIndex);
            Console.WriteLine("Введите endIndex:");
            Int32.TryParse(Console.ReadLine(), out int endIndex);
            DisplayList(currencies.GetRange(startIndex, (endIndex - startIndex) + 1));
        }

        private static void DisplayList(IEnumerable<string> list)
        {
            Console.WriteLine(String.Join("\n", list));
        }
    }
}
