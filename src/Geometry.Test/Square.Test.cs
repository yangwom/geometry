namespace Geometry.Test;

public class SquareTest
{
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [Theory]
    public void TestSquare(double side)
    {
         var instance = new Square(side);
         instance.GetType().IsInstanceOfType(nameof(Rectangle));
    }
}