namespace Geometry.Test;

public class RectangleTest
{
    [InlineData(2, 2)]
    [InlineData(10, 5)]
    [Theory]
    public void TestRectangle(double sideA, double sideB)
    {
        var instance = new Rectangle(sideA, sideB);
        var result = sideA * sideB;
        instance.Width.Should().Be(sideA);
        instance.Height.Should().Be(sideB);
        instance.Area.Should().Be(result);

    }

    [InlineData(0, 4)]
    [InlineData(4, 0)]
    [InlineData(4, -1)]
    [InlineData(-1, 4)]
    [Theory]
    public void TestRectangleNonPositiveSideException(double sideA, double sideB)
    {
       Action act = () => new Rectangle(sideA, sideB);

       act.Should().Throw<ArgumentException>().WithMessage("All sides must be greater than zero");
    }
}