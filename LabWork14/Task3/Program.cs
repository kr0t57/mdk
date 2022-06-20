using System;
using System.Linq;

namespace Task3
{
    internal sealed class Program
    {
        private static void Main()
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            string[] suggestions = text.Split(new[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim()).ToArray();

            Console.WriteLine(String.Join("\n", suggestions));
        }
    }
}
