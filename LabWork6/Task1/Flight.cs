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

        internal object this[int index]
        {
            get
            {
                switch (index)
                {
                    case 1:
                        return _destination;
                    case 2:
                        return _flightNumber;
                    case 3:
                        return _capacity;
                    default:
                        return null;
                }
            }
        }

        internal string this[int index, object a]
        {
            get => $"{this[index] ?? string.Empty}";
        }
    }
}
