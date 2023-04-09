namespace Домашка_от_31._03_про_класс_геометрических_фигур;

public class GeometricFigure
{
    private Type _type;
    private int[] _side;
    private int _sideCount;
    private Color _color;
    private int[] _angle;
    
    private int _area;
    private double perimeter;

    public GeometricFigure(Type type, int[] side, int sideCount, Color color, int[] angle)
    {
        _type  = type;
        _color = color;
        _side  = side;
        
        _sideCount = sideCount;
        
        if (_type == Type.Triangle && _sideCount != 3)
            throw new Exception("You kidding, right?");
        if (_type == Type.Square && _sideCount != 4)
            throw new Exception("You kidding, right?");
        if (_type == Type.Rhombus && _sideCount != 4)
            throw new Exception("You kidding, right?");
        if (_type == Type.Trapezoid && _sideCount != 4)
            throw new Exception("You kidding, right?");
        if (_type == Type.Circle && _sideCount != 1)
            throw new Exception("You kidding, right?");

        _angle = angle;
        
        if (_angle.Count() == 4 && _angle.Sum() != 360)
            throw new Exception("You kidding, right? You have 4 angles, and their sum must equal 360");
        if (_angle.Count() == 3 && _angle.Sum() != 180)
            throw new Exception("You kidding, right? You have 3 angles, and their sum must equal 180");
    }
    
    
}