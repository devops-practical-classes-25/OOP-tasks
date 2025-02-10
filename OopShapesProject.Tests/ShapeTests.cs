namespace OopShapesProject.Tests;
using Xunit;
using System;

public class ShapeTests
{
    [Fact]
    public void Circle_GetArea_ReturnsCorrectValue()
    {
        var circle = new Circle(2);
        Assert.Equal(Math.PI * 4, circle.GetArea(), 5);
    }

    [Fact]
    public void Circle_GetPerimeter_ReturnsCorrectValue()
    {
        var circle = new Circle(2);
        Assert.Equal(2 * Math.PI * 2, circle.GetPerimeter(), 5);
    }

    [Fact]
    public void Rectangle_GetArea_ReturnsCorrectValue()
    {
        var rectangle = new Rectangle(3, 4);
        Assert.Equal(12, rectangle.GetArea());
    }

    [Fact]
    public void Rectangle_GetPerimeter_ReturnsCorrectValue()
    {
        var rectangle = new Rectangle(3, 4);
        Assert.Equal(14, rectangle.GetPerimeter());
    }

    [Fact]
    public void Circle_NegativeRadius_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }

    [Fact]
    public void Rectangle_NegativeWidth_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new Rectangle(-2, 3));
    }
}