using ShapeLibrary.Models.AbstractClasses;
using ShapeLibrary.Models.ConcreteClasses;

namespace ExternalClient
{
    internal class Program
    {
        static void Main()
        {
            List<Shape> shapes = new()
            {
                new Circle(5),
                new Triangle(3, 4, 5)
            };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(value: $"Area {shape.CalculateArea()}");
                if (shape is Triangle triangle)
                {
                    Console.WriteLine($"Is the triangle right-angled? {triangle.IsRightAngled()}");
                }
            }

        }
    }
}