using System;

namespace Task2
{
    public sealed class Rectagle : IShape
    {
        public void Draw()
        {
            Console.WriteLine($"Inside {GetType().Name}");
        }
    }
}
