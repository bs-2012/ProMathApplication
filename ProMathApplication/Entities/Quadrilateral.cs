namespace ProMathApplication.Entities
{
    public class Quadrilateral : Shape
    {
        #region Private Fields

        private readonly double _length;
        private readonly double _width;

        #endregion

        #region Constructor

        public Quadrilateral(double length, double width)
        {
            _length = length;
            _width = width;
        }

        #endregion

        #region Properties

        public override string Name
        {
            get
            {
                return _length == _width ? "Square" : "Rectangle";
            }
        }

        public override double Perimeter
        {
            get
            {
                return (_width + _length) * 2;
            }
        }

        public override double Area
        {
            get
            {
                return _length * _width;
            }
        }

        #endregion
    }
}
