using ShapeLibrary.Interfaces;
using ShapeLibrary.Models.ConcreteClasses;
using ShapeLibrary.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestShapeLibrary
{
    public class TriangleTests
    {
        [Fact]
        public void Triangle_WithValidSides_ReturnsArea()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double expectedArea = 6;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            IVisitor visitor = new AreaVisitor();
            // Act
            double actualArea = triangle.CalculateArea(visitor);

            // Assert
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void Triangle_WithInvalidSides_ThrowsArgumentException()
        {
            // Arrange
            double sideA = 1;
            double sideB = 2;
            double sideC = 3;

            // Act and Assert
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Fact]
        public void Triangle_WithNegativeSides_ThrowsArgumentException()
        {
            // Arrange
            double sideA = -3;
            double sideB = 4;
            double sideC = 5;

            // Act and Assert
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Fact]
        public void Triangle_WithZeroSides_ThrowsArgumentException()
        {
            // Arrange
            double sideA = 3;
            double sideB = 0;
            double sideC = 5;

            // Act and Assert
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Fact]
        public void Triangle_WithRightAngledSides_ReturnsTrue()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.True(isRightAngled);
        }

        [Fact]
        public void Triangle_WithNonRightAngledSides_ReturnsFalse()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 6;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.False(isRightAngled);
        }
    }
}
