using ShapeLibrary.Models.ConcreteClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Interfaces
{
    public interface IVisitor
    {
        double Visit(Circle circle);
        double Visit(Triangle triangle);
    }
}
