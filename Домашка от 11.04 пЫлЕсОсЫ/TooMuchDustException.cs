using System.Runtime.Serialization;

namespace Домашка_от_11._04_пЫлЕсОсЫ;

public class TooMuchDustException : Exception
{
    public TooMuchDustException()
    {
    }
    protected TooMuchDustException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
    public TooMuchDustException(string message) : base(message)
    {
    }
    public TooMuchDustException(string message, Exception innerException) : base(message, innerException)
    {
    }
}