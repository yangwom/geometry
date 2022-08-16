namespace Geometry.Test;

public class ParallelepipedTest
{
    [InlineData(2, 3, 4)]
    [InlineData(3, 4, 5)]
    [Theory]
    public void TestParallelepiped(double height, double width, double depth)
    {
        var expected = new Parallelepiped(height, width, depth);

        expected.Height.Should().Be(height);
        expected.Width.Should().Be(width);
        expected.Depth.Should().Be(depth);
        expected.Volume.Should().Be(width * height * depth);
        expected.FaceA.Area.Should().Be(width * height);
        expected.FaceB.Area.Should().Be(width * depth);
        expected.FaceC.Area.Should().Be(height * depth);
        

    }
}