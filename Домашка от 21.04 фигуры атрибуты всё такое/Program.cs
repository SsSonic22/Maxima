// See https://aka.ms/new-console-template for more information

using Домашка_от_31._03_про_класс_геометрических_фигур;

internal class Program
{
    public static void Main()
    {
        var typeOfGeometricFigure = typeof(GeometricFigure);
        foreach (var att in typeOfGeometricFigure.GetCustomAttributes(true))
        {
            if (att is FigureAttribute figureAttribute)
            {
                Console.WriteLine($"Чтобы найти эту фигуру, загляните в {figureAttribute}");
            }
        }
    }
}