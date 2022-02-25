using System.Collections.Generic;
using ProMathApplication.Entities;
using ProMathApplication.Enums;

namespace ProMathApplication.Interfaces
{
    public interface IShapeManager
    {
        List<Shape> SortShapes(List<Shape> shapes, ShapeSortBy sortBy);

        string SerializeShapes(List<Shape> shapes);
    }
}
