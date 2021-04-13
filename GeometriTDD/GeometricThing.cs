using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriTDD
{
    abstract class GeometricThing
    {
        public abstract int Area();
        public abstract int Omkrets();
    }

    class Square : GeometricThing
    {
        int side;
        public Square(int n) => side = n;
        public override int Area() => side * side;
        public override int Omkrets() => side * 4;
    }

    class Triangle : GeometricThing
    {
        int side1;
        int side2;

        public Triangle(int n1) => side1 = n1;

        public Triangle(int n1, int n2) 
        {
            side1 = n1;
            side2 = n2;
        }

        public int AreaLiksidig() => side1 * side1 / 2;
        public int OmkretsLiksidig() => side1 * 3;
        public override int Area() => side1 * side2 / 2;
        public override int Omkrets() => side1 + side2;
    }

    //class 
}
