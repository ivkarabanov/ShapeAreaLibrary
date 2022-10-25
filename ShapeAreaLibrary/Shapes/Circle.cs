namespace ShapeAreaLibrary.Shapes;

public class Circle : Shape
{
    private readonly float _radius;

    internal Circle(float radius)
    {
        _radius = radius;
    }

    public override double Area => Math.PI * Math.Pow(_radius, 2);
}