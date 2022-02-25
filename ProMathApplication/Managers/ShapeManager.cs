using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using ProMathApplication.Entities;
using ProMathApplication.Enums;
using ProMathApplication.Interfaces;

namespace ProMathApplication.Managers
{
    public class ShapeManager : IShapeManager
    {
        public List<Shape> SortShapes(List<Shape> shapes, ShapeSortBy sortBy)
        {
            if (shapes == null || !shapes.Any())
                throw new ArgumentNullException(nameof(shapes), "No shapes found");

            switch (sortBy)
            {
                case ShapeSortBy.Area:
                    return shapes.OrderBy(shape => shape.Area).ToList();
                case ShapeSortBy.Perimeter:
                    return shapes.OrderBy(shape => shape.Perimeter).ToList();
                default:
                    return shapes;
            }
        }

        public string SerializeShapes(List<Shape> shapes)
        {
            return JsonSerializer.Serialize(shapes);
        }
    }
}
