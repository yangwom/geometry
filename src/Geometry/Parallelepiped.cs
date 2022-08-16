namespace Geometry;
public class Parallelepiped
{

    double _width;
    double _height;
    double _depth;

    public double Width { get => _width; set {
      if( value <= 0) throw new ArgumentException("All sides must be greater than zero");
      _width = value;
    } }
    public double Height { get => _height; set {
      if( value <= 0) throw new ArgumentException("All sides must be greater than zero");
      _height = value;
    } }
    public double Depth { get => _depth; set {
      if( value <= 0) throw new ArgumentException("All sides must be greater than zero");
      _depth = value;
    } }

    public Rectangle FaceA { get; set; }

    public Rectangle FaceB { get; set; }

    public Rectangle FaceC { get; set; }

    public double SurfaceArea { get { return (FaceA.Area * 2) + (FaceB.Area * 2) + (FaceC.Area * 2); } }

    public double Volume { get { return Width * Height * Depth; } }

    public Parallelepiped(double height, double width, double depth)
    {
     
      Height = height;
      Width = width;
      Depth = depth;
    FaceA = new Rectangle(width, height);
    FaceB = new Rectangle(width, depth);
    FaceC = new Rectangle(height, depth);
    }

}
