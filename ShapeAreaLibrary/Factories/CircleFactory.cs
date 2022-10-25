using ShapeAreaLibrary.Exceptions;
using ShapeAreaLibrary.Shapes;

namespace ShapeAreaLibrary.Factories;

public sealed class CircleFactory
{
    public Shape CreateShape(float radius)
    {
        if (radius <= 0)
        {
            throw new InvalidShapeException("Ошибка создания круга. Радиус должен быть положительным числом.");
        }

        return new Circle(radius);
    }
}