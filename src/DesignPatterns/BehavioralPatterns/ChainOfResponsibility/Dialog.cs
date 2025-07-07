namespace ChainOfResponsibility;

public class Dialog: Widget
{
    public Dialog(HelpHandler parent, HelpTopic topic) : base(parent, topic)
    {
        
    }

    public override string HandleHelp()
    {
        if (HasHelp)
        {
            if (Topic == HelpTopic.Printing)
            {
                return "This is a dialog for printing.";
            }
        }
        return base.HandleHelp();
    }
}