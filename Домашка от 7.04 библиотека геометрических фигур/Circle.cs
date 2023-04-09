using Домашка_от_7._04_библиотека_геометрических_фигур;

public class Circle : IFigure
{
    private double _R;

    public Circle(int i, double r)
    {
        _R = r;
    }

    public double R => _R;
    public double Diameter => 2 * _R;

    public double Area => Math.PI * Math.Pow(_R, 2);
    public double Perimeter => 2 * Math.PI * _R; 

    public FigureType FigureType => FigureType.Circle;

    public string GetTitle()
    {
        return "Circle";
    }
}