using ShapeAreaLibrary.Common;

namespace ShapeAreaLibrary.Shapes;

internal class Triangle : Shape
{
    private readonly float _side1;
    private readonly float _side2;
    private readonly float _side3;

    internal Triangle(float side1, float side2, float side3)
    {
        _side1 = side1;
        _side2 = side2;
        _side3 = side3;
    }

    public override double Area
    {
        get
        {
            var semiPerimeter = 0.5d * ((double)_side1 + _side2 + _side3);
            var area = Math.Sqrt(semiPerimeter * (semiPerimeter - _side1) * (semiPerimeter - _side2) * (semiPerimeter - _side3));
            return area;
        }
    }

    public bool Right
    {
        get
        {
            var longestSide = Math.Max(Math.Max(_side1, _side2), _side3);
            var leg1 = Math.Abs(_side1 - longestSide) < Constants.Epsilon ? _side2 : _side1;
            var leg2 = Math.Abs(_side2 - longestSide) < Constants.Epsilon ? _side3 : _side2;
            return Math.Abs(Math.Pow(leg1, 2) + Math.Pow(leg2, 2) - Math.Pow(longestSide, 2)) < Constants.Epsilon;
        }
    }
}