namespace Decorator;

public class IndentDecorator: IComponent
{
    private IComponent _subComp;
    public IndentDecorator(IComponent subComp)
    {
        _subComp = subComp;
    }
    public string Draw()
    {
        return "  " + _subComp.Draw();
    }
}