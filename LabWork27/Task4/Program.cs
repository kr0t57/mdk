using System;
using System.Linq;

namespace Task4
{
    internal sealed class Program
    {
        private static void Main(string[] args)
        {
            var subject = new Subject();

            new HexObserver(subject);
            new OctalObserver(subject);
            new BinaryObserver(subject);

            Console.WriteLine("First state change: 15");
            subject.State = 15;
        }
    }
}
