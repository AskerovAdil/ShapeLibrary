using ShapeLibrary.Interfaces;
using ShapeLibrary.Models.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Models.ConcreteClasses
{
    public class Circle : Shape
    {
        public double Radius { get; private set; }
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius must be positive and non-zero");
            }
            Radius = radius;
        }

        public override double CalculateArea(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }

}
