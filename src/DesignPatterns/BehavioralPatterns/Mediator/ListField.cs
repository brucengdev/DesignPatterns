namespace Mediator;

public class ListField: Widget
{
    private string[] _options = [];
    public ListField(string label, DialogDirector director)
    {
    }

    public void AddItems(params string[] options)
    {
        _options = options;
    }
}