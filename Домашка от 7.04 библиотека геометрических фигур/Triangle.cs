using Домашка_от_7._04_библиотека_геометрических_фигур;

public class Triangle : IFigure
{
    private double _a, _b, _c;

    public Triangle(double a, double b, double c)
    {
        _a = a;
        _b = b;
        _c = c;
    }

    public double A => _a;

    public double B => _b;

    public double C => _c;

    public double Area => throw new Exception("Не умею");
    public double Perimeter => _a + _b + _c;

    public FigureType FigureType => FigureType.Triangle;

    public string GetTitle()
    {
        return "Triangle";
    }
}