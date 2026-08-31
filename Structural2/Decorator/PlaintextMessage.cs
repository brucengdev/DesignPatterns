namespace Decorator;

public class PlaintextMessage : IMessage
{
    private string _message;
    public PlaintextMessage(string message)
    {
        _message = message;
    }
    public string Message => _message;
}