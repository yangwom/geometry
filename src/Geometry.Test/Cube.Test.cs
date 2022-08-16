namespace Geometry.Test;

public class CubeTest
{
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [Theory]
    public void TestCube(double side)
    {
     var instance = new Cube(side);

     instance.Side.Should().Be(side);
     instance.GetType().IsInstanceOfType(nameof(Parallelepiped));
     var resultBoolean = instance.FaceA.Area == instance.FaceB.Area && instance.FaceA.Area == instance.FaceC.Area && instance.FaceB.Area == instance.FaceC.Area;
     resultBoolean.Should().Be(true);

    instance.Volume.Should().Be(side * side * side);

    }
}