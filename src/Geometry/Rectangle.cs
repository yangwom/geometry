using static System.Console;
namespace Geometry;
public class Rectangle
{    

      double  _width;

      double _height;
    
     static void Main()
     {
        // teste
       var instance = new Square(1);
        WriteLine($" eu sou filho de rectangle: {instance.Area}");
     }
    public double Width { get { return _width; } set {
        if(value < 0) throw new ArgumentException("All sides must be greater than zero");
        _width = value;
    }}
    public double Height { get { return _height; } set {
        if(value < 0) throw new ArgumentException("All sides must be greater than zero");
        _height = value;
    } }
    public double Area { get { return Width * Height; }}

    public double Perimeter { get { return Width + Height; } }

    public Rectangle(double width, double height) {
    Width = width;
    Height = height;
    }
}