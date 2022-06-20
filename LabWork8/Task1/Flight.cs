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

        public override string ToString()
        {
            return $"\nМесто назначения: {_destination},\nНомер Рейса: {_flightNumber},\nВместимость: {_capacity}\n";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Flight flight = obj as Flight;
            return _destination == flight._destination && _flightNumber == flight._flightNumber && _capacity == flight._capacity;
        }
    }
}
