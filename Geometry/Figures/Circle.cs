using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry.Figures
{
    public class Circle : Figure
    {
        public Circle(float radius) : base(new float[] { radius }) { }

        public override float GetArea() => MathF.PI * MathF.Pow(Lengths[0], 2);
    }
}
