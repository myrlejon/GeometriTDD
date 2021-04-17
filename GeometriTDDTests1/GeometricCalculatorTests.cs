using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometriTDD;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriTDD.Tests
{
    [TestClass()]
    public class GeometricCalculatorTests
    {
        [TestMethod()]
        public void GetAreaTest()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetArea(new GeometricThing[]
            {
                new Geometry.Square(10)
            });
        }
        //[DataRow(1.0f, 1.0f)]

        [TestMethod()]
        public void GetPerimeterTest()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetPerimeter(new GeometricThing[]
            {
                new Geometry.Square(10)
            });
        }


    }
}