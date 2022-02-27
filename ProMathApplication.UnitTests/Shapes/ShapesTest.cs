using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProMathApplication.Entities;
using ProMathApplication.Enums;
using ProMathApplication.Managers;

namespace ProMathApplication.UnitTests.Shapes
{
    [TestClass]
    public class ShapesTest
    {
        #region Local Fields

        List<Shape> _shapes;

        #endregion Local Fields

        #region Initializer

        [TestInitialize]
        public void Setup()
        {
            var circle = new Circle(2);
            var equilateralTriangle = new Triangle(1, 2, 1, 1, 1);
            var isoscelesTriangle = new Triangle(1, 2, 1, 2, 1);
            var scaleneTriangle = new Triangle(1, 2, 1, 2, 3);
            var square = new Square(5);
            var rectangle = new Rectangle(5, 10);

            _shapes = new List<Shape>();
            _shapes.Add(circle);
            _shapes.Add(equilateralTriangle);
            _shapes.Add(isoscelesTriangle);
            _shapes.Add(scaleneTriangle);
            _shapes.Add(square);
            _shapes.Add(rectangle);
        }

        #endregion Initializer

        #region Test Methods

        [TestMethod]
        [Description("Validates area of circle calculation is correct")]
        public void ValidateCircleArea()
        {
            var circle = new Circle(2);
            var area = Math.PI * 2 * 2;
            Assert.AreEqual<double>(area, circle.Area);
        }

        [TestMethod]
        [Description("Shapes.SortShapes Validates if shapes collections is null")]
        public void ValidateShapesSortNullCheck()
        {
            var manager = new ShapeManager();
            Assert.ThrowsException<ArgumentNullException>(() => manager.SortShapes(null, ShapeSortBy.Area));
        }

        [TestMethod]
        [Description("Shapes.SortShapes Validates if shapes collections is sorted by Area")]
        public void ValidateShapesSortArea()
        {
            var manager = new ShapeManager();
            Assert.IsTrue(manager.SortShapes(_shapes, ShapeSortBy.Area).First().Area == 1);
        }

        [TestMethod]
        [Description("Shapes.SortShapes Validates if shapes collections is sorted by Perimeter")]
        public void ValidateShapesSortPerimeter()
        {
            var manager = new ShapeManager();
            Assert.IsTrue(manager.SortShapes(_shapes, ShapeSortBy.Perimeter).First().Perimeter == 3);
        }

        #endregion Test Methods
    }
}
