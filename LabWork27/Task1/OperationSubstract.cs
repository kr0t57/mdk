namespace Task1
{
    public sealed class OperationSubstract : IStrategy
    {
        public int DoOperation(int a, int b)
        {
            return a - b;
        }
    }
}
