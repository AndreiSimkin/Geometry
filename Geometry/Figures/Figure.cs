using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Geometry.Figures
{
    public class Figure
    {
        protected float[] Lengths { get; set; }
        public Figure(float[] lengths)
        {
            Lengths = lengths;
        }

        public virtual float GetArea()
        {
            if (Lengths.Length == 1)
                return new Circle(Lengths[0]).GetArea();
            else if (Lengths.Length == 3)
                return new Triangle(Lengths[0], Lengths[1], Lengths[2]).GetArea();
            else
                return -1;
        }
    }
}
