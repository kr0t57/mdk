using System;

namespace Task1
{
    internal struct Flight
    {
        private string _destination;
        private int _number;
        private int _capacity;

        internal FlightType flightType;

        internal Flight(string destination, int number, int capacity)
        {
            _destination = destination;
            _number = number;
            _capacity = capacity;
            flightType = FlightType.Internal;
        }

        internal string Destination 
        {
            get => _destination;
            set => _destination = value.Length > 1 ? value : _destination;
        }
        internal int Number
        {
            get => _number;
            set => _number = value < 0 ? _number : value;
        }
        internal int Capacity
        {
            get => _capacity;
            set => _capacity = value < 0 ? _capacity : value;
        }

        internal void Display()
        {
            Console.WriteLine($"Destination: {_destination}\nNumber: {_number}\nCapacity: {_capacity}\nFlightType: {Enum.GetName(typeof(FlightType), flightType)}\n");
        }
    }
}
