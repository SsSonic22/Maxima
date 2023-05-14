using System.Runtime.Serialization;

namespace Домашка_от_11._04_пули_патроны_стреляю;

public class OverheatException : Exception
{
    public OverheatException()
    {
    }
    public OverheatException(string message) : base(message)
    {
    }
    public OverheatException(string message, Exception inner) : base(message, inner)
    {
    }
}