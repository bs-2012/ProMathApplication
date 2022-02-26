using System;

namespace ProMathApplication.Entities
{
    public class Circle : Shape
    {
        #region Private Fields

        private readonly double _radius;
        private double? _area = null;
        private double? _perimeter = null;

        #endregion

        #region Constructor

        public Circle(double radius)
        {
            _radius = radius;
        }

        #endregion

        #region Properties

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
                if (!_perimeter.HasValue)
                    _perimeter = Math.PI * 2 * _radius;

                return _perimeter.Value;
            }
        }

        public override double Area
        {
            get
            {
                if (!_area.HasValue)
                    _area = Math.PI * _radius * _radius;

                return _area.Value;
            }
        }

        #endregion
    }
}
