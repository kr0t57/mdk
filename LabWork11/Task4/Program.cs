using System;
using System.Collections.Generic;

namespace Task4
{
    internal sealed class Program
    {
        private static void Main(string[] args)
        {
            List<string> currencies = new List<string> { "ruble", "dollar", "euro" };

            Console.Write("Введите startIndex: ");
            Int32.TryParse(Console.ReadLine(), out int startIndex);

            Console.Write("Введите endIndex: ");
            Int32.TryParse(Console.ReadLine(), out int endIndex);

            bool indexsesIsCorrect = startIndex >= 0 && endIndex < currencies.Count;
            Console.WriteLine(indexsesIsCorrect ? string.Join("\n", currencies.GetRange(startIndex, (endIndex - startIndex) + 1)) : "Indexses is incorrect");
        }
    }
}
