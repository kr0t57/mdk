using System;

namespace Task1
{
    internal sealed class Flight : IPrinter
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

        public void Print()
        {
            Console.WriteLine($"Destination: {_destination}\nFlight Number: {_flightNumber}\nCapacity: {_capacity}");
        }
    }
}
