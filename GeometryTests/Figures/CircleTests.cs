using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geometry.Figures;
using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry.Figures.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void GetArea_05_i78f53982()
        {
            // arrange
            float radius = 5;
            float expected = (float)78.53982;

            //act
            Circle circle = new Circle(radius);
            float actual = circle.GetArea();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetArea_10_i314f15927()
        {
            // arrange
            float radius = 10;
            float expected = (float)314.15927;

            //act
            Circle circle = new Circle(radius);
            float actual = circle.GetArea();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetArea_15_i706f85834()
        {
            // arrange
            float radius = 15;
            float expected = (float)706.85834;

            //act
            Circle circle = new Circle(radius);
            float actual = circle.GetArea();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetArea_20_i1256f6371()
        {
            // arrange
            float radius = 20;
            float expected = (float)1256.6371;

            //act
            Circle circle = new Circle(radius);
            float actual = circle.GetArea();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}