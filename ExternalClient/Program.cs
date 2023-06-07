using ShapeLibrary.Interfaces;
using ShapeLibrary.Models.AbstractClasses;
using ShapeLibrary.Models.ConcreteClasses;
using ShapeLibrary.Visitors;

namespace ExternalClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle(5));
            shapes.Add(new Triangle (3,4,5));
            IVisitor visitor = new AreaVisitor(); 
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(value: $"Area {shape.CalculateArea(visitor)}");
            }

        }
    }
}