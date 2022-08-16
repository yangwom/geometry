namespace Geometry;
public class Cube : Parallelepiped
{

    public double Side { get; set; }

    public Square FaceA { get; set; }
    public Square FaceB { get; set; }
    public Square FaceC { get; set; }
    public Cube(double side): base(side,  side,  side){

        Side = side;

    FaceA = new Square(side);
    FaceB = new Square(side);
    FaceC = new Square(side);
    }
}