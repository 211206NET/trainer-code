namespace CustomExceptions;
public class InputInvalidException : Exception
{
    public InputInvalidException() { }
    public InputInvalidException(string message) : base(message) { }
    public InputInvalidException(string message, Exception inner) : base(message, inner) { }
    protected InputInvalidException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}