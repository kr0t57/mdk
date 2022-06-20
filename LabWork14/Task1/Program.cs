using System;
using System.Collections.Generic;

namespace Task1
{
    internal sealed class Program
    {
        private static void Main()
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            Console.Write("Введите символ для поиска: ");
            char symb = Console.ReadKey().KeyChar;

            List<int> indices = new List<int>();

            int lastIndex = str.IndexOf(symb);
            while (lastIndex > -1)
            {
                indices.Add(lastIndex);
                lastIndex = str.IndexOf(symb, lastIndex + 1);
            }

            Console.WriteLine("\nИндексы: {0}", String.Join(", ", indices));
        }
    }
}
