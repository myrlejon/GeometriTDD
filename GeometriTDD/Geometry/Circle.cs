using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriTDD.Geometry
{
    public class Circle : GeometricThing
    {
        public float Radie { get; set; }
        public Circle(float radie)
        {
            Radie = radie;
        }

        public override float GetArea()
        {
            return Radie * Radie * 3.1415926535f;
        }

        public override float GetPerimeter()
        {
            return (Radie * 2) * 3.1415926535f;
        }
    }
}
