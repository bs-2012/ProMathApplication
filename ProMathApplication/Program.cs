using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ProMathApplication.Entities;
using ProMathApplication.Enums;
using ProMathApplication.Managers;

namespace ProMathApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(2);
            var equilateralTriangle = new Triangle(1, 2, 1, 1, 1);
            var isoscelesTriangle = new Triangle(1, 2, 1, 2, 1);
            var scaleneTriangle = new Triangle(1, 2, 1, 2, 3);
            var square = new Square(5);
            var rectangle = new Rectangle(5, 10);

            var shapes = new List<Shape>();
            shapes.Add(circle);
            shapes.Add(equilateralTriangle);
            shapes.Add(isoscelesTriangle);
            shapes.Add(scaleneTriangle);
            shapes.Add(square);
            shapes.Add(rectangle);


            var manager = new ShapeManager();
            //Sort shapes by area or perimeter
            manager.SortShapes(shapes, ShapeSortBy.Area).ForEach(shape =>
            {
                Console.WriteLine($"{shape.Name}, Area: {shape.Area}");
            });


            PrintIntializedObjectList();
            PrintShapesToFile(shapes, SerializeShapeFormat.Json);
        }

        private static void PrintIntializedObjectList()
        {
            var initializedObjects = Shape.GetInitializedObjectCount();

            if(initializedObjects== null || !initializedObjects.Any())
            {
                Console.WriteLine("No objects initialzed for Shape");
                return;
            }                

            foreach (var item in initializedObjects)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        private static async Task PrintShapesToFile(List<Shape> shapes, SerializeShapeFormat format)
        {
            if (shapes == null || !shapes.Any())
                return;

            var serializerFactory = new ProSerializerFactory();

            var factory = serializerFactory.GetFactory(format);

            if(factory == null)
            {
                Console.WriteLine("Factory not found");
                return;
            }               

            var shapesData = factory.Serialize(shapes);
            using StreamWriter file = new("ShapesData.txt");
            await file.WriteLineAsync(shapesData);
        }
    }
}
