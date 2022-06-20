using System;

namespace Task
{
    internal sealed class Program
    {
        private static void Main()
        {
            Random random = new Random();

            Flight[] array = new Flight[10];

            for (int i = 0; i < array.Length; i++)
            {
                int capacity = random.Next(array.Length);
                array[i] = new Flight("USA", 137, capacity);
            }

            Console.WriteLine("До:\n");
            DisplayArray(array);
            Array.Sort(array);
            Console.WriteLine("После:\n");
            DisplayArray(array);
        }

        private static void DisplayArray(Flight[] array)
        {
            foreach (Flight flight in array)
            {
                Console.WriteLine($"Destination: {flight.Destination}\nFlightNumber: {flight.FlightNumber}\nCapacity: {flight.Capacity}\n");
            }
        }
    }
}
