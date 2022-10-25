using ShapeAreaLibrary.Common;
using ShapeAreaLibrary.Shapes;
using Xunit;

namespace ShapeAreaLibrary.UnitTests;

public class TriangleTests
{
    [Theory]
    [InlineData(2, 2, 3, 1.9843134832984429428762118152294)]
    [InlineData(3, 4, 5, 6)]
    [InlineData(float.MaxValue, float.MaxValue, float.MaxValue,5.0139439441307764E+76)]
    public void Area_ShouldReturnCorrectNumber(float side1, float side2, float side3, double area)
    {
        //Arrange
        var triangle = new Triangle(side1, side2, side3);
        
        //Act
        var calculatedArea = triangle.Area;

        //Assert
        Assert.Equal(area, calculatedArea, Constants.Epsilon);
    }
    
    [Theory]
    [InlineData(3, 4, 5)]
    [InlineData(5, 12, 13)]
    public void Right_ShouldReturnTrue_IfRightTriangle(float side1, float side2, float side3)
    {
        //Arrange
        var triangle = new Triangle(side1, side2, side3);
        
        //Act
        var result = triangle.Right;

        //Assert
        Assert.True(result);
    }
    
        
    [Theory]
    [InlineData(4, 4, 5)]
    [InlineData(6, 12, 13)]
    public void Right_ShouldReturnFalse_IfNotRightTriangle(float side1, float side2, float side3)
    {
        //Arrange
        var triangle = new Triangle(side1, side2, side3);
        
        //Act
        var result = triangle.Right;

        //Assert
        Assert.False(result);
    }
}