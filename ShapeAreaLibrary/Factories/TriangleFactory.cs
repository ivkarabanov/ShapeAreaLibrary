using ShapeAreaLibrary.Common;
using ShapeAreaLibrary.Exceptions;
using ShapeAreaLibrary.Shapes;

namespace ShapeAreaLibrary.Factories;

public sealed class TriangleFactory
{
    public Shape CreateShape(float side1, float side2, float side3)
    {
        if (side1 <= 0 || side2 <= 0 || side3 <= 0)
        {
            throw new InvalidShapeException("Ошибка создания треугольника. Сторона треугольника должна быть выражена положительным числом.");
        }
        
        if (side1 + side2 - side3 <= Constants.Epsilon ||
            side1 + side3 - side2  <= Constants.Epsilon ||
            side2 + side3 - side1  <= Constants.Epsilon)
        {
            throw new InvalidShapeException("Ошибка создания треугольника. Неверное соотношение сторон.");
        }
        
        return new Triangle(side1, side2, side3);
    }
}