using System;
using System.Linq;
using System.Collections.Generic;

namespace Task4
{
    internal sealed class Program
    {
        private static void Main()
        {
            List<string> currencies = new List<string> { "ruble", "dollar", "euro" };

            int lastElementIndex = currencies.Count - 1;

            string temp = currencies.First();
            currencies[0] = currencies[lastElementIndex];
            currencies[lastElementIndex] = temp;

            DisplayList(currencies);
        }

        private static void DisplayList(IEnumerable<string> list)
        {
            Console.WriteLine(String.Join("\n", list));
        }
    }
}
