using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriTDD
{
    /// <summary>
    /// Denna klassen innehåller metoder som beräknar omkrets och area om en eller flera former.
    /// Alla metoder är baserade på klassen GeometricThing.
    /// </summary>
    public class GeometricCalculator
    {
        /// <summary>
        /// Denna metoden används för att räkna ut omkretsen av en geometrisk form (Triangle, Square, Rectangle, Circle).
        /// </summary>
        /// <param name="thing"></param>
        /// <returns></returns>
        public float GetPerimeter(GeometricThing thing)
        {
            float perimeter = 0;
            float shape = thing.GetPerimeter();
            if (shape > 0)
            {
                perimeter = shape;
            }
            return perimeter;
        }

        /// <summary>
        /// Denna metoden används för att räkna ut omkretsen av en eller flera geometrisk former (Triangle, Square, Rectangle, Circle).
        /// </summary>
        /// <param name="things"></param>
        /// <returns></returns>
        public float GetPerimeter(GeometricThing[] things)
        {
            float perimeter = 0;
            if (things.Length > 0)
            {
                for (int i = 0; i < things.Length; i++)
                {
                    float shape = things[i].GetPerimeter();
                    if (shape > 0)
                    {
                        perimeter += things[i].GetPerimeter();
                    }
                }
            }
            return perimeter;
        }

        /// <summary>
        /// Denna metoden används för att räkna ut arean av en geometrisk form (Triangle, Square, Rectangle, Circle).
        /// </summary>
        /// <param name="thing"></param>
        /// <returns></returns>
        public float GetArea(GeometricThing thing)
        {
            float area = 0;
            float shape = thing.GetArea();
            if (shape > 0)
            {
                area = shape;
            }
            return area;
        }

        /// <summary>
        /// Denna metoden används för att räkna ut arean av en eller flera geometriska former (Triangle, Square, Rectangle, Circle).
        /// </summary>
        /// <param name="things"></param>
        /// <returns></returns>
        public float GetArea(GeometricThing[] things)
        {
            float area = 0;
            if (things.Length > 0)
            {
                for (int i = 0; i < things.Length; i++)
                {
                    float shape = things[i].GetArea();
                    if (shape > 0)
                    {
                        area += things[i].GetArea();
                    }
                }
            }
            return area;
        }
    }
}
