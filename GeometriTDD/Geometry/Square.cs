using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriTDD.Geometry
{
    public class Square : GeometricThing
    {
        public float Side { get; set; }

        public Square(float side)
        {
            Side = side;
        }

        public override float GetArea()
        {
            return Side * 2;
        }

        public override float GetPerimeter()
        {
            return Side * 4;
        }
    }
}
