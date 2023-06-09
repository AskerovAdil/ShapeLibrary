using ShapeLibrary.Models.ConcreteClasses;

namespace TestShapeLibrary
{
    public class CircleTests
    {
        [Fact]
        public void Circle_WithPositiveRadius_ReturnsArea()
        {
            // Arrange
            double radius = 5;
            double expectedArea = Math.PI * Math.Pow(radius, 2);
            Circle circle = new(radius);
            // Act
            double actualArea = circle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void Circle_WithZeroRadius_ThrowsArgumentException()
        {
            // Arrange
            double radius = 0;

            // Act and Assert
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [Fact]
        public void Circle_WithNegativeRadius_ThrowsArgumentException()
        {
            // Arrange
            double radius = -5;

            // Act and Assert
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}