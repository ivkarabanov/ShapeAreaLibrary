using ShapeAreaLibrary.Common;
using ShapeAreaLibrary.Shapes;
using Xunit;

namespace ShapeAreaLibrary.UnitTests;

public class CircleTests
{
    [Theory]
    [InlineData(1, 3.14159265358979323846)]
    [InlineData(2, 12.566370614359172953850573533118)]
    [InlineData(float.MaxValue, 3.6377153352681637488616497401769e+77)]
    public void Area_ShouldReturnCorrectNumber(float radius, double area)
    {
        //Arrange
        var circle = new Circle(radius);
        
        //Act
        var calculatedArea = circle.Area;

        //Assert
        Assert.Equal(area, calculatedArea, Constants.Epsilon);
    }
}