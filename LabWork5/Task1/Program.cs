using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    internal sealed class Program
    {
        private static void Main(string[] args)
        {
            //Flight defaultFlight = new Flight();
            //Flight flight = new Flight("USA",747,1000);

            //Flight flight = new Flight("USA",747,1000);
            //flight.DisplayInfo();

            Flight[] flights = new Flight[]
            {
               new Flight("USA",747,1000),
               new Flight("Russia",123,2),
               new Flight("China",299,1999999),
               new Flight("USA",453,456),
               new Flight("China",137,135)
            };

            //1
            Console.WriteLine("Введите пункт назначения: ");
            string destination = Console.ReadLine();

            IEnumerable<Flight> flightsWithDestanation = flights.Where(x => x.Destination.ToLower() == destination.ToLower());

            if (flightsWithDestanation.Count() == 0)
            {
                Console.WriteLine("Ближайших рейсов нет!\n");
            }
            else
            {
                foreach (Flight flight in flightsWithDestanation)
                {
                    flight.DisplayInfo();
                }
            }

            //2
            Console.WriteLine("Введите вместимость: ");
            int capacity = int.Parse(Console.ReadLine());

            IEnumerable<Flight> flightsWithCapacity = flights.Where(x => x.Capacity == capacity);

            if (flightsWithCapacity.Count() == 0)
            {
                Console.WriteLine("Рейсов с такой вместимостью не найдено!\n");
            }
            else
            {
                foreach (Flight flight in flightsWithCapacity)
                {
                    flight.DisplayInfo();
                }
            }
        }
    }
}
