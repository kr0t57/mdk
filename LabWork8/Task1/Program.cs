using System;
using System.Text;

namespace Task1
{
    internal sealed class Program
    {
        private static void Main(string[] args)
        {
            // 1
            Console.WriteLine("[1]");
            Flight flight = new Flight("USA", 100, 20);
            Console.WriteLine(flight);
            Console.WriteLine(flight.ToString());

            // 2
            Console.WriteLine("[2]");
            Console.WriteLine("flight2:");
            Flight flight2 = new Flight("USA", 100, 20);
            Console.WriteLine(flight2);

            Console.WriteLine("flight3:");
            Flight flight3 = new Flight("USA", 120, 20);
            Console.WriteLine(flight3);
            Console.WriteLine($"flight2.Equals(flight3): {flight2.Equals(flight3)}");

            Console.WriteLine();
            Console.WriteLine();
            Generator generator = new Generator();
            Console.WriteLine(generator.GetRandomLine(100));
        }
    }
}
