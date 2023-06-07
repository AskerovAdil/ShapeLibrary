using ShapeLibrary.Interfaces;

namespace ShapeLibrary.Models.AbstractClasses
{
    public abstract class Shape
    {
        public abstract double CalculateArea(IVisitor visitor);
    }

}
