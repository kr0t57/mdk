using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    internal sealed class Program
    {
        private static void Main()
        {
            List<string> currencies = new List<string> { "ruble", "dollar", "euro" };

            Console.Write("Введите букву: ");
            char symb = Console.ReadKey().KeyChar;
            DisplayList(currencies.Where(x => x.StartsWith(symb)));
        }

        private static void DisplayList(IEnumerable<string> list)
        {
            Console.WriteLine("\n{0}", String.Join("\n", list));
        }
    }
}
