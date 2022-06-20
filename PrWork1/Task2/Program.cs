using System;
using System.IO;
using System.Text;

namespace Task2
{
    internal sealed class Program
    {
        private static void Main()
        {
            Console.Write("Введите путь: ");
            var path = Console.ReadLine();
            
            if (!File.Exists(path))
            {
                try
                {
                    File.Create(path);
                    Console.WriteLine($"Файл {path} создан");
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
            else
            {
                Console.WriteLine("Файл открыт на дозапись.\nДля остановки введите: end.");
            }

            var sb = new StringBuilder();
            var line = string.Empty;

            while (true)
            {
                line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                sb.AppendLine(line);
            }

            try
            {
                File.AppendAllText(path, sb.ToString());
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
