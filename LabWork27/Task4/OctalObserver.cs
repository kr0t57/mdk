using System;

namespace Task4
{
    public sealed class OctalObserver : Observer
    {
        public OctalObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine($"Octal String: {Convert.ToString(subject.State, 8)}");
        }
    }
}
