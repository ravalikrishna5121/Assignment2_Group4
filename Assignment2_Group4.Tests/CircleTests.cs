using Assignment2_Group4;
using NUnit.Framework;
using System;

namespace Assignment2_Group4

{
    public class CircleTest
    {


       [Test]
        public void GetRadiusTest1_InputPositive()
        {
            //Arrange
            Circle circle = new Circle(5);
            //Actual
            int actual = circle.GetRadius();
            //Assert
            Assert.AreEqual(5, actual);
        }
        [Test]
        public void GetRadiusTest2_Input0()
        {
            Circle circle = new Circle(0);
            int actual = circle.GetRadius();
            Assert.AreEqual(0, actual);
        }
        [Test]

        public void GetRadiusTest3_InputNegative()
        {
            Circle circle = new Circle(-1);
            int actual = circle.GetRadius();
            Assert.AreEqual(-1, actual);
        }
        [Test]
        public void SetRadiusTest1_InputPositive()
        {
            Circle circle = new Circle(5);
            int radius = 5;
            circle.SetRadius(radius);
            int actual = circle.GetRadius();
            Assert.AreEqual(radius, actual);

        }

        [Test]
        public void SetRadiusTest2_InputNegative()
        {
            Circle circle = new Circle(-5);
            int radius = -5;
            circle.SetRadius(radius);
            int actual = circle.GetRadius();
            Assert.AreEqual(radius, actual);

        }

        [Test]
        public void SetRadiusTest3_Input0()
        {
            Circle circle = new Circle(0);
            int radius = 0;
            circle.SetRadius(radius);
            int actual = circle.GetRadius();
            Assert.AreEqual(radius, actual);

        }

        [Test]

        public void GetCircumferenceTest1_InputPositive()
        {
            Circle circle = new Circle(1);
            double expected = 6.28;
            double actual = Math.Round(circle.GetCircumference(), 2);
            Assert.AreEqual(expected, actual);
        }

        [Test]


        public void GetCircumferenceTest2_InputNegative()
        {
            Circle circle = new Circle(-5);
            double expected = -31.42;
            double actual = Math.Round(circle.GetCircumference(), 2);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetCircumferenceTest3_InputRadius0()
        {
            Circle circle = new Circle(0);
            double expected = 0;
            double actual = circle.GetCircumference();
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetAreaTest1_InputPositive()
        {
            Circle circle = new Circle(2);
            double expected = 12.57;
            double actual = Math.Round(circle.GetArea(), 2);
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetAreaTest2_InputNegative()
        {
            Circle circle = new Circle(-10);
            double expected = 314;
            double actual = Math.Round(circle.GetArea());
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetAreaTest3_Input0()
        {
            Circle circle = new Circle(0);
            double expected = 0;
            double actual = (circle.GetArea());
            Assert.AreEqual(expected, actual);

        }

    }
}