using System;

namespace GeometriTDD
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Geometry.Triangle(10);
            var square = new Geometry.Square(10);
            var circle = new Geometry.Circle(5);
            var rectangle = new Geometry.Rectangle(10, 20);

            GeometricThing[] array = new GeometricThing[] { square, triangle, circle, rectangle };
            var geocal = new GeometricCalculator();
            Console.WriteLine(geocal.GetArea(square));
        }
    }
}
