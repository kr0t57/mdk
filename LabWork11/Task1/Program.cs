using System;
using System.Collections.Generic;

namespace Task1
{
    internal sealed class Program
    {
        private static void Main()
        {
            List<string> currencies = new List<string> { "ruble", "dollar", "euro" };

            Console.WriteLine("Введите n:");
            int.TryParse(Console.ReadLine(), out int n);

            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите валюту: ");
                currencies.Add(Console.ReadLine());
            }

            Console.WriteLine($"Количество элементов: {currencies.Count}");
            for (int i = 0; i < currencies.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {currencies[i]}");
            }
        }
    }
}
