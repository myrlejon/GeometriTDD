using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriTDD
{
    public class GeometricCalculator
    {

        public float GetPerimeter(GeometricThing thing)
        {
            float perimeter;
            perimeter = thing.GetArea();
            return perimeter;
        }

        public float GetPerimeter(GeometricThing[] things)
        {
            float perimeter = 0;
            for (int i = 0; i < things.Length; i++)
            {
                perimeter += things[i].GetPerimeter();
            }
            return perimeter;
        }

        public float GetArea(GeometricThing thing)
        {
            float area;
            area = thing.GetArea();
            return area;
        }

        public float GetArea(GeometricThing[] things)
        {
            float area = 0;
            for (int i = 0; i < things.Length; i++)
            {
                area += things[i].GetArea();
            }
            return area;
        }
    }
}
