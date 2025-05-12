namespace Decorator;

public class QuotedDecorator: IComponent
{
    private IComponent _subComp;
    public QuotedDecorator(IComponent subComp)
    {
        _subComp = subComp;
    }
    public string Draw()
    {
        return "\"" + _subComp.Draw() + "\"";
    }
}