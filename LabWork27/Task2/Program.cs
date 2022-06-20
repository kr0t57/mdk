namespace Task2
{
    internal sealed class Program
    {
        private static void Main()
        {
            var shapeFactory = new ShapeFactory();

            var rectangle = shapeFactory.GetShape(nameof(Rectagle));
            rectangle.Draw();

            var square = shapeFactory.GetShape(nameof(Square));
            square.Draw();

            var circle = shapeFactory.GetShape(nameof(Circle));
            circle.Draw();
        }
    }
}
