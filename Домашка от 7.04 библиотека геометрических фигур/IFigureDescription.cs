namespace Домашка_от_7._04_библиотека_геометрических_фигур;

public interface IFigureDescription
{
    public FigureType FigureType { get; }
    
    public string GetTitle()
    {
        return "Unkown Figure";
    }
}