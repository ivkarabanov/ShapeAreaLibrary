using ShapeAreaLibrary.Exceptions;
using ShapeAreaLibrary.Factories;
using Xunit;

namespace ShapeAreaLibrary.UnitTests;

public class TriangleFactoryTests
{
    [Theory]
    [InlineData(2, 3, 4)]
    [InlineData(3,4,5)]
    [InlineData(float.MaxValue, float.MaxValue, float.MaxValue)]
    public void CreateShape_PassCorrectData_ShouldCreateShape(float side1, float side2, float side3)
    {
        //Arrange
        var factory = new TriangleFactory();

        //Act
        var shape = factory.CreateShape(side1, side2, side3);

        //Assert
        Assert.NotNull(shape);
    }
    
    [Theory]
    [InlineData(0 , 1, 2)]
    [InlineData(-1, -1, -5)]
    [InlineData(1, 1, 4)]
    public void CreateShape_PassIncorrectCorrectData_ShouldThrowException(float side1, float side2, float side3)
    {
        //Arrange
        var factory = new TriangleFactory();

        //Act & Arrange
        Assert.Throws<InvalidShapeException>(() => factory.CreateShape(side1, side2, side3));
    }
}