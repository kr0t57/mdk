namespace Task1
{
    public interface IFigure
    {
        public string Name { get; }

        public double GetSquare();
        public double GetPerimetr();
        public void DisplayInfo();
    }
}
