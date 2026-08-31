namespace Decorator;

public class Border: MessageDecorator
{

    public Border(IMessage message) : base(message)
    {
        
    }

    public override string Message => $"<<{_message.Message}>>";
}