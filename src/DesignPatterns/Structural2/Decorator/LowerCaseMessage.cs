namespace Decorator;

public class LowerCaseMessage(IMessage message): MessageDecorator(message)
{
    public override string Message => _message.Message.ToLower();
}