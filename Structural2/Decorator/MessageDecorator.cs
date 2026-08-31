namespace Decorator;

public class MessageDecorator: IMessage
{
    protected IMessage _message;

    public MessageDecorator(IMessage message)
    {
        _message = message;
    }

    public void Replace(IMessage another)
    {
        _message = another;
    }
    public virtual string Message => _message.Message;
}