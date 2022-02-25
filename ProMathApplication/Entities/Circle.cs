using System;

namespace ProMathApplication.Entities
{
    public class Circle : Shape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override string Name
        {
            get
            {
                return "Circle";
            }
        }

        public override double Perimeter
        {
            get
            {
                return Math.PI * 2 * _radius;
            }
        }

        public override double Area
        {
            get
            {
                return Math.PI * _radius * _radius;
            }
        }
    }
}
