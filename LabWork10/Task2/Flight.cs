using System;

namespace Task2
{
    internal sealed class Flight : IComparable<Flight>
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

        public int CompareTo(Flight flight)
        {
            if (flight == null)
            {
                return 1;
            }
            return flight._capacity.CompareTo(_capacity);
        }
    }
}
