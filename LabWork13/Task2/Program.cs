using System;
using System.Linq;
using System.Collections.Generic;

namespace Task2
{
    internal sealed class Program
    {
        private static void Main()
        {
            List<string> currencies = new List<string> { "ruble", "dollar", "ruble", "ruble", "ruble", "euro" };
            
            Console.Write("Введите значение: ");
            string value = Console.ReadLine();
            currencies.RemoveAll(x => x == value);
            DisplayList(currencies);
        }

        private static void DisplayList(IEnumerable<string> list)
        {
            Console.WriteLine(String.Join("\n", list));
        }
    }
}
