using System;

namespace Task
{
    internal sealed class Flight : IComparable
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

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            return (obj as Flight)._capacity.CompareTo(_capacity);
        }
    }
}
