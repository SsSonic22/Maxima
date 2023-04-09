using Домашка_от_7._04_библиотека_геометрических_фигур;

public class Square : IFigure
{
    private double _a;

    public Square(int i, double a)
    {
        _a = a;
    }

    public double A => _a;

    public double Diagonal => Math.Sqrt(2) * _a;

    public double Area => _a * _a;

    public double Perimeter => 4 * _a;

    public FigureType FigureType => FigureType.Square;


    public string GetTitle()
    {
        return "Square";
    }
}