using ShapeAreaLibrary.Exceptions;
using ShapeAreaLibrary.Factories;
using Xunit;

namespace ShapeAreaLibrary.UnitTests;

public class CircleFactoryTests
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(float.MaxValue)]
    public void CreateShape_PassCorrectData_ShouldCreateShape(float radius)
    {
        //Arrange
        var factory = new CircleFactory();

        //Act
        var shape = factory.CreateShape(radius);

        //Assert
        Assert.NotNull(shape);
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(float.MinValue)]
    public void CreateShape_PassIncorrectCorrectData_ShouldThrowException(float radius)
    {
        //Arrange
        var factory = new CircleFactory();

        //Act & Arrange
        Assert.Throws<InvalidShapeException>(() => factory.CreateShape(radius));
    }
}