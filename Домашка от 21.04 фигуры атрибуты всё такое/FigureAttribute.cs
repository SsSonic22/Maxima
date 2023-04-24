namespace Домашка_от_31._03_про_класс_геометрических_фигур;

[AttributeUsage(AttributeTargets.All)]
/// понятия не имею, какой фигурам придумать атрибут поэтому этьо атрибут класса типа 5в 9г 
public class FigureAttribute : Attribute
{
    public int ClassNumber { get; set; }
    public string  ClassLetter{ get; set; }

    public FigureAttribute(int number, string letter)
    {
        ClassNumber = number;
        ClassLetter = letter;
    }

    public override string ToString()
    {
        return $"класс {ClassNumber}{ClassLetter}";
    }
}