using ShapeLibrary.Models.AbstractClasses;

namespace ShapeLibrary.Models.ConcreteClasses
{
    public class Triangle : Shape
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Error: Sides must be positive and non-zero");
            }
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                throw new ArgumentException("Error: Sides do not form a valid triangle");
            }
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double CalculateArea()
        {
            double semiPerimeter = (SideA + SideB + SideC) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
            return area;
        }

        public bool IsRightAngled()
        {
            bool isRightAngled = (SideA == Math.Sqrt(Math.Pow(SideB, 2) + Math.Pow(SideC, 2))
             || SideB == Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideC, 2))
             || SideC == Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2)));
            return isRightAngled;
        }
    }
}
