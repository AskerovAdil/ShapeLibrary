using ShapeLibrary.Interfaces;
using ShapeLibrary.Models.ConcreteClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Visitors
{
    public class AreaVisitor : IVisitor
    {
        public double Visit(Circle circle)
        {
            return Math.PI * Math.Pow(circle.Radius, 2);
        }

        public double Visit(Triangle triangle)
        {
            double semiPerimeter = (triangle.SideA + triangle.SideB + triangle.SideC) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - triangle.SideA) * 
                (semiPerimeter - triangle.SideB) * (semiPerimeter - triangle.SideC));
            return area;
        }

    }
}
