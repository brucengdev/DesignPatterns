namespace Decorator;

public class UpperCaseMessage: MessageDecorator
{
    public UpperCaseMessage(IMessage message) : base(message)
    {
    }

    public override string Message => _message.Message.ToUpper();
}