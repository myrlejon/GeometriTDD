using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriTDD.Geometry
{
    public class Rectangle : GeometricThing
    {
        public float Bas { get; set; }
        public float Height { get; set; }

        public Rectangle(float bas, float height)
        {
            Bas = bas;
            Height = height;
        }

        public override float GetArea()
        {
            return Bas * Height;
        }

        public override float GetPerimeter()
        {
            return Bas + Bas + Height + Height;
        }
    }
}
