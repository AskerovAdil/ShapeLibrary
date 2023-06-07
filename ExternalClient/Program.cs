using ShapeLibrary.Models.AbstractClasses;
using ShapeLibrary.Models.ConcreteClasses;

namespace ExternalClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle(5));
            shapes.Add(new Triangle (3,4,5));

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(value: $"Area {shape.CalculateArea()}");
            }

        }
    }
}