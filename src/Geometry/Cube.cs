namespace Geometry;
public class Cube : Parallelepiped
{

    public double Side { get; set; }
    public Cube(double side): base(side,  side,  side){

        Side = side;

    FaceA = new Square(side);
    FaceB = new Square(side);
    FaceC = new Square(side);
    }
}