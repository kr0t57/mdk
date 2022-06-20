using System;

namespace Task4
{
    public sealed class HexObserver : Observer
    {
        public HexObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine($"Hex String: {Convert.ToString(subject.State, 16)}");
        }
    }
}
