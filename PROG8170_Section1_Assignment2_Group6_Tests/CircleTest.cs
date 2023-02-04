/*
Assignment-2 SQAT
PROG-8170 SEC-1

Done by: Group-6
Syed Sirajul Hasan - 8836760
Piyush Mansukhbhai Monpara - 8784742

File: CircleTest.cs
*/

using PROG8170_Section1_Assignment2_Group6;
using NUnit.Framework;

namespace PROG8170_Section1_Assignment2_Group6_Tests
{
    [TestFixture]
    public class CircleTest
    {
        //GetRadius() - 3 UnitTests - Valid, Negative and Zero Input

        [Test]
        public void GetRadius_ValidInput_ReturnsExpectedResult()
        {
            // Arrange
            Circle c = new Circle(5);

            // Act
            int actual = c.GetRadius();

            // Assert
            Assert.AreEqual(5, actual);
        }

        [Test]
        public void GetRadius_NegativeInput_ReturnsOne()
        {
            // Arrange
            Circle c = new Circle(-5);

            // Act
            int actual = c.GetRadius();

            // Assert
            Assert.AreEqual(1, actual);
        }

        [Test]
        public void GetRadius_ZeroInput_ReturnsOne()
        {
            // Arrange
            Circle c = new Circle(0);

            // Act
            int actual = c.GetRadius();

            // Assert
            Assert.AreEqual(1, actual);
        }

        //SetRadius() - 3 UnitTests - Valid, Negative and Zero Input

        [Test]
        public void SetRadius_ValidInput_ReturnsExpectedResult()
        {
            // Arrange
            Circle c = new Circle();
            int radius = 5;
            double expected = 31.42;

            // Act
            c.SetRadius(radius);
            double actual = c.GetCircumference();

            // Assert
            Assert.AreEqual(expected, actual, 0.01);
        }

        [Test]
        public void SetRadius_NegativeInput_ReturnsOne()
        {
            // Arrange
            Circle c = new Circle();
            int radius = -5;
            double expected = 31.42;

            // Act
            c.SetRadius(radius);
            double actual = c.GetCircumference();

            // Assert
            Assert.AreEqual(expected, actual, 0.01);
        }

        [Test]
        public void SetRadius_ZeroInput_ReturnsOne()
        {
            // Arrange
            Circle c = new Circle();
            int radius = 0;
            double expected = 3.14;

            // Act
            c.SetRadius(radius);
            double actual = c.GetCircumference();

            // Assert
            Assert.AreEqual(expected, actual, 0.01);
        }

        //GetCircumference() - 3 UnitTests - Valid, Negative and Zero Input

        [Test]
        public void GetCircumference_ValidInput_ReturnsExpectedResult()
        {
            // Arrange
            Circle c = new Circle(5);

            // Act
            double actual = c.GetCircumference();

            // Assert
            Assert.AreEqual(31.42, actual, 0.01);
        }

        [Test]
        public void GetCircumference_NegativeInput_ReturnsExpectedResult()
        {
            // Arrange
            Circle c = new Circle(-5);

            // Act
            double actual = c.GetCircumference();

            // Assert
            Assert.AreEqual(31.42, actual, 0.01);
        }

        [Test]
        public void GetCircumference_ZeroInput_ReturnsExpectedResult()
        {
            // Arrange
            Circle c = new Circle(0);

            // Act
            double actual = c.GetCircumference();

            // Assert
            Assert.AreEqual(6.28, actual, 0.01);
        }

        //GetArea() - 3 UnitTests - Valid, Negative and Zero Input

        [Test]
        public void GetArea_ValidInput_ReturnsExpectedResult()
        {
            // Arrange
            Circle c = new Circle(5);

            // Act
            double actual = c.GetArea();

            // Assert
            Assert.AreEqual(78.53, actual, 0.01);
        }

        [Test]
        public void GetArea_NegativeInput_ReturnsExpectedResult()
        {
            // Arrange
            Circle c = new Circle(-5);

            // Act
            double actual = c.GetArea();

            // Assert
            Assert.AreEqual(78.53, actual, 0.01);
        }

        [Test]
        public void GetArea_ZeroInput_ReturnsExpectedResult()
        {
            // Arrange
            Circle c = new Circle(0);

            // Act
            double actual = c.GetArea();

            // Assert
            Assert.AreEqual(3.14, actual, 0.01);
        }

    }

}
