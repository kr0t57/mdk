using System;
using System.Text.RegularExpressions;

namespace Task2
{
    internal sealed class Program
    {
        private static void Main()
        {
            Console.WriteLine("Введите строку:");
            string line = Console.ReadLine();
            Console.WriteLine(Regex.Replace(line, @"\s+", " "));
        }
    }
}
