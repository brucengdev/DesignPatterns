namespace ChainOfResponsibility;

public abstract class Widget: HelpHandler
{
    protected Widget(HelpHandler successor, HelpTopic topic) : base(successor, topic)
    {
    }
}