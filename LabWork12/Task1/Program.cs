using System;
using System.Linq;

namespace Task1
{
    internal sealed class Program
    {
        private static void Main()
        {
            //1
            Flight defaultFlight = new Flight();
            Flight flight = new Flight("USA", 15, 200);

            defaultFlight.Display();
            flight.Display();

            //2
            Flight correctFlight = new Flight("USA", 15, 200);
            correctFlight.Display();
            Flight incorrectFlight = new Flight("U", -15, -200);
            incorrectFlight.Display();

            //4
            Flight[] flights = new Flight[]
            {
                new Flight("USA", 15, 200) {flightType = FlightType.Internal},
                new Flight("USA", 15, 200) {flightType = FlightType.International},
                new Flight("USA", 15, 200) {flightType = FlightType.Internal},
                new Flight("USA", 15, 200) {flightType = FlightType.International},
                new Flight("USA", 15, 200) {flightType = FlightType.International}
            };

            Console.Write("Введите тип для поиска: ");
            string flightTypeForSearch = Console.ReadLine();

            Flight[] findedFlights = flights.Where(x => Enum.GetName(typeof(FlightType), x.flightType) == flightTypeForSearch).ToArray();

            foreach (Flight findedFlight in findedFlights)
            {
                findedFlight.Display();
            }
        }
    }
}
