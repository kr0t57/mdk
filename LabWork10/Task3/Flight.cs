using System;

namespace Task3
{
    internal sealed class Flight : IEquatable<Flight>
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

        public bool Equals(Flight flight)
        {
            return flight._destination == _destination && flight._flightNumber == _flightNumber && flight._capacity == _capacity;
        }
    }
}
