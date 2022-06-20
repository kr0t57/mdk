using System;

namespace Task1
{
    internal sealed class Flight
    {
        private string _destination;
        private int _flightNumber;
        private int _capacity;

        internal Flight() : this("USA", 128, 263)
        {
            
        }

        internal Flight(string destination, int flightNumber, int capacity)
        {
            _destination = destination;
            _flightNumber = flightNumber;
            _capacity = capacity;
        }

        internal string Destination => _destination;
        internal int FlightNumber => _flightNumber;
        internal int Capacity => _capacity;

        public static Flight operator ++(Flight flight)
        {
            flight._capacity++;
            return flight;
        }

        public static Flight operator +(Flight flight, Flight flight2)
        {
            return new Flight(flight.Destination, flight.FlightNumber, flight.Capacity + flight2.Capacity);
        }

        public static bool operator ==(Flight flight, Flight flight2)
        {
            return flight.Destination == flight2.Destination && flight.FlightNumber == flight2.FlightNumber && flight.Capacity == flight2.Capacity;
        }

        public static bool operator !=(Flight flight, Flight flight2)
        {
            return flight.Destination != flight2.Destination || flight.FlightNumber != flight2.FlightNumber || flight.Capacity != flight2.Capacity;
        }

        public static bool operator true(Flight flight)
        {
            return flight._capacity >= 0;
        }

        public static bool operator false(Flight flight)
        {
            return flight._capacity < 0;
        }

        internal void DisplayInfo()
        {
            Console.WriteLine($"\nМесто назначения: {_destination},\nНомер Рейса: {_flightNumber},\nВместимость: {_capacity}\n");
        }
    }
}
