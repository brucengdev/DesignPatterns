namespace Decorator;

public class TextComponent: IComponent
{
    private string _content;
    public TextComponent(string content)
    {
        _content = content;
    }
    public string Draw()
    {
        return _content;
    }
}