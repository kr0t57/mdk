using System;

namespace Task4
{
    public sealed class BinaryObserver : Observer
    {
        public BinaryObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine($"Binary String: {Convert.ToString(subject.State, 2)}");
        }
    }
}
