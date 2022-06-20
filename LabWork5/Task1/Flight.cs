using System;

namespace Task1
{
    internal sealed class Flight
    {
        private string _destination;
        private int _flightNumber;
        private int _capacity;

        internal Flight()
        {

        }

        internal Flight(string destination, int flightNumber, int capacity)
        {
            Destination = destination;
            FlightNumber = flightNumber;
            Capacity = capacity;
        }

        internal string Destination
        {
            get => _destination;
            set => _destination = value.Length > 1 ? value : string.Empty;
        }

        internal int FlightNumber
        {
            get => _flightNumber;
            set => _flightNumber = _flightNumber >= 0 ? value : -1;
        }

        internal int Capacity
        {
            get => _capacity;
            set => _capacity = _capacity >= 0 ? value : -1;
        }

        internal void DisplayInfo()
        {
            Console.WriteLine($"\nМесто назначения: {_destination},\nНомер Рейса: {_flightNumber},\nВместимость: {_capacity}\n");
        }
    }
}
