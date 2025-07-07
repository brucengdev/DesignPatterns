namespace ChainOfResponsibility;

public abstract class HelpHandler
{
    protected HelpHandler Successor;
    protected HelpTopic Topic;

    public HelpHandler(HelpHandler successor, HelpTopic topic = HelpTopic.NoTopic)
    {
        Successor = successor;
        Topic = topic;
    }
    
    //make it virtual so subclasses can override
    public virtual string HandleHelp()
    {
        if (Successor != null)
        {
            return Successor.HandleHelp();
        }

        return "No help message";
    }

    public bool HasHelp => Topic != HelpTopic.NoTopic;
}