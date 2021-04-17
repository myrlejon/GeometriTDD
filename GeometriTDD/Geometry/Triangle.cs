using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriTDD.Geometry
{
    public class Triangle : GeometricThing
    {
        public float Bas { get; set; }
        public float Height { get; set; }
        public float Side3 { get; set; }

        public Triangle()
        {

        }

        // Liksidig triangel
        public Triangle(float bas)
        {
            Bas = bas;
        }


        public Triangle(float bas, float height)
        {
            Bas = bas;
            Height = height;
        }

        public override float GetArea()
        {
            return Bas * Height / 2;
        }

        public override float GetPerimeter()
        {
            float pythagoras = (float)Math.Sqrt(Bas * Bas) + (float)Math.Sqrt(Height * Height) / 2;
            return Bas + Height + pythagoras;
        }
    }
}
