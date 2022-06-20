using System;

namespace Task3
{
    internal sealed class DataEventArgs : EventArgs
    {
        public string Parameter { get; set; }
        public DateTime Date { get; set; }
    }
}
