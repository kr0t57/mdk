using System;

namespace Task3
{
    internal sealed class Program
    {
        private static void Main(string[] args)
        {
            Flight flight = new Flight("USA", 100, 50);
            Flight flight2 = new Flight("USA", 100, 50);
            Console.WriteLine("flight == flight2: {0}", flight.Equals(flight2));
        }
    }
}
