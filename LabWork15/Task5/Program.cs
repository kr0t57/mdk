using System;
using System.Text.RegularExpressions;

namespace Task5
{
    internal sealed class Program
    {
        private static void Main()
        {
            Console.WriteLine("Введите строку:");
            string line = Console.ReadLine();

            Console.WriteLine(Regex.Replace(line, @"\b(?<day>0?[1-9]|[12]\d|3[01])[./](?<month>0?[1-9]|[1-9]|1[0-2])[./](?<year>\d{4}|\d{2})\b", "${year}-${month}-${day}"));
        }
    }
}
