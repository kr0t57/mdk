using System;
using System.Text;

namespace Task1
{
    public sealed class Generator : Random
    {
        public string GetRandomLine(int length)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                int randomCase = Next(2); // 0 - lowerCase, 1 - UpperCase
                sb.Append((char)(randomCase == 0 ? Next('a', 'z' + 1) : Next('A', 'Z' + 1)));
            }
            return sb.ToString();
        }
    }
}
