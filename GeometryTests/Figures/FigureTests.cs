using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geometry.Figures;
using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry.Figures.Tests
{
    [TestClass()]
    public class FigureTests
    {
        [TestMethod()]
        public void GetArea_a11b9c13_120()
        {
            // arrange
            float a = 11;
            float b = 9;
            float c = 13;

            float expected = (float)48.80766;

            //act
            Figure figure = new Figure(new float[] { a, b, c });
            float actual = figure.GetArea();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetArea_05_i78f53982()
        {
            // arrange
            float radius = 5;
            float expected = (float)78.53982;

            //act
            Figure circle = new Figure(new float[] { radius });
            float actual = circle.GetArea();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetArea_a11b9_neg1()
        {
            // arrange
            float a = 11;
            float b = 9;

            float expected = -1;

            //act
            Figure figure = new Figure(new float[] { a, b });
            float actual = figure.GetArea();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}