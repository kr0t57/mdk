using System;

namespace Task2
{
    public sealed class ShapeFactory
    {
        public IShape GetShape(string shapeType)
        {
            if (shapeType.Equals(nameof(Rectagle), StringComparison.InvariantCultureIgnoreCase))
            {
                return new Rectagle();
            }

            if (shapeType.Equals(nameof(Square), StringComparison.InvariantCultureIgnoreCase))
            {
                return new Square();
            }

            if (shapeType.Equals(nameof(Circle), StringComparison.InvariantCultureIgnoreCase))
            {
                return new Circle();
            }

            return null;
        }
    }
}
