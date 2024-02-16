using NUnit.Framework;
namespace NUnitDemonstration.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void ScaleneTriangle_ValidInput_ReturnsValidMessage1()
        {
            // Arrange
            int firstAngle = 80;
            int secondAngle = 70;
            int thirdAngle = 30;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }
        [Test]
        public void ScaleneTriangle_InvalidInput_ReturnsvalidMessage()
        {
            // Arrange
            double firstAngle = 45.5;
            double secondAngle = 104.5;
            int thirdAngle = 30;
            // Act
            string result = Triangle.InvalidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }
        
        [Test]
        public void IsoscelesTriangle_validInput_ReturnsvalidMessage()
        {
            // Arrange
            int firstAngle = 80;
            int secondAngle = 50;
            int thirdAngle = 50;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }

        [Test]
        public void IsoscelesTriangle_InvalidInput_ReturnsvalidMessage()
        {
            // Arrange
            int firstAngle = -30;
            int secondAngle = 90;
            int thirdAngle = 90;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }

        [Test]
        
        public void EquilateralTriangle_ValidInput_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }

        [Test]
        public void EquilateralTriangle_InvalidInput_ReturnsInvalidMessage()
        {
            // Arrange
            int firstAngle = 0;
            int secondAngle = 0;
            int thirdAngle = 0;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }

        [Test]
        public void LargeEquilateralTriangle_InvalidInput_ReturnsInvalidMessage()
        {
            // Arrange
            int firstAngle = 1000;
            int secondAngle = 1000;
            int thirdAngle = 1000;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is NOT valid.", result);
        }
    }
}
