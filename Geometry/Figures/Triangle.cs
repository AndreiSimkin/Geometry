using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Geometry.Figures
{
    public class Triangle : Figure
    {
        public Triangle(float a, float b, float c) : base(new float[] { a, b, c }) { } 

        public bool IsRight { get {
                float[] sides = Lengths;
                Array.Sort(sides);
                return MathF.Pow(sides[2], 2) == MathF.Pow(sides[0], 2) + MathF.Pow(sides[1], 2);
            } }

        public override float GetArea()
        {
            float p = Lengths.Sum() / 2;
            return MathF.Sqrt(p * (p - Lengths[0]) * (p - Lengths[1]) * (p - Lengths[2]));
        }
    }
}
