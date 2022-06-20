using System;

namespace Task1
{
    internal sealed class Program
    {
        private static void Main(string[] args)
        {
            // 1 
            Console.WriteLine("[1]");

            Flight flight = new Flight("USA", 100, 150);
            Console.WriteLine($"До {flight.Capacity}");
            flight++;
            Console.WriteLine($"После {flight.Capacity}");

            // 2
            Console.WriteLine("[2]");

            Flight flight2 = new Flight("CHINA", 128, 15);
            Flight flight3 = new Flight("RUSSIA", 100, 25);
            Flight flight4 = flight2 + flight3;

            flight2.DisplayInfo();
            flight3.DisplayInfo();
            flight4.DisplayInfo();

            // 3
            Console.WriteLine("[3]");

            Flight flight5 = new Flight("CHINA", 128, 15);
            Flight flight6 = new Flight("RUSSIA", 100, 25);

            Console.WriteLine($"{nameof(flight5)}:");
            flight5.DisplayInfo();
            Console.WriteLine($"{nameof(flight6)}:");
            flight6.DisplayInfo();

            Console.WriteLine($"{nameof(flight5)} == {nameof(flight6)}: {flight5 == flight6}");
            Console.WriteLine($"{nameof(flight5)} != {nameof(flight6)}: {flight5 != flight6}");

            // 4
            Console.WriteLine("[4]");

            Flight flight7 = new Flight("CHINA", 128, 15);
            flight7.DisplayInfo();

            if (flight7)
            {
                Console.WriteLine("result: true");
            }
            else
            {
                Console.WriteLine("result: false");
            }
        }
    }
}
