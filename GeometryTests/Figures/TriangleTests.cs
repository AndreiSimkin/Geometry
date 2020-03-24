using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geometry.Figures;
using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry.Figures.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void GetArea_a10b24c26_120()
        {
            // arrange
            float a = 10;
            float b = 24;
            float c = 26;

            float expected = 120;

            //act
            Triangle triangle = new Triangle(a, b, c);
            float actual = triangle.GetArea();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetArea_a11b9c13_120()
        {
            // arrange
            float a = 11;
            float b = 9;
            float c = 13;

            float expected = (float)48.80766;

            //act
            Triangle triangle = new Triangle(a, b, c);
            float actual = triangle.GetArea();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsRight_a11b9c13_false()
        {
            // arrange
            float a = 11;
            float b = 9;
            float c = 13;

            bool expected = false;

            //act
            Triangle triangle = new Triangle(a, b, c);
            bool actual = triangle.IsRight;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsRight_a10b24c26_true()
        {
            // arrange
            float a = 10;
            float b = 24;
            float c = 26;

            bool expected = true;

            //act
            Triangle triangle = new Triangle(a, b, c);
            bool actual = triangle.IsRight;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}