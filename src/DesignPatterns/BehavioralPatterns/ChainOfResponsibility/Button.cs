namespace ChainOfResponsibility;

public class Button: Widget
{
    private string _label;
    public Button(string label, Widget parent, HelpTopic topic) : base(parent, topic)
    {
        _label = label;
    }
}