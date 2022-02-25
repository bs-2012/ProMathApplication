namespace ProMathApplication.Entities
{
    public class Triangle : Shape
    {
        private readonly double _height;
        private readonly double _base;
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        public Triangle(double height, double triangleBase, double sideA, double sideB, double sideC)
        {
            _height = height;
            _base = triangleBase;
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public override string Name
        {
            get
            {
                if (SideAEqualsSideB() && SideBEqualsSideC() && SideCEqualsSideA())
                    return "Equilateral Triangle";

                if (SideAEqualsSideB() || SideBEqualsSideC() || SideCEqualsSideA())                
                    return "Isosceles Triangle";

                return "Scalene Triangle";                

                bool SideAEqualsSideB() => _sideA == _sideB;
                bool SideBEqualsSideC() => _sideB == _sideC;
                bool SideCEqualsSideA() => _sideC == _sideA;
            }
        }

        public override double Perimeter
        {
            get
            {
                return _sideA + _sideB + _sideC;
            }
        }

        public override double Area
        {
            get
            {
                return (_height * _base) / 2;
            }
        }
    }
}
