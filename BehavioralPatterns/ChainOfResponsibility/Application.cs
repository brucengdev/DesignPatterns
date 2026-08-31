namespace ChainOfResponsibility;

public class Application: HelpHandler
{
    public Application(HelpTopic topic) : base(null, topic)
    {
    }
    
}