using System;
using System.Linq;
using System.Collections.Generic;

namespace Task5
{
    internal sealed class Program
    {
        private static void Main()
        {
            List<string> currencies = new List<string> { "ruble", "dollar", "euro" };

            Console.WriteLine("Введите число элементов:");
            Int32.TryParse(Console.ReadLine(), out int count);

            if (count < 0 || count > currencies.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            currencies.Sort();
            currencies.Reverse();
            DisplayList(currencies.GetRange(0, count));
        }

        private static void DisplayList(IEnumerable<string> list)
        {
            Console.WriteLine(String.Join("\n", list));
        }
    }
}
