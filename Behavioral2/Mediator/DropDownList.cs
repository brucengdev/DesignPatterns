namespace Mediator;

public class DropDownList: Control
{
    private List<string> _options;
    private int _value = 0;
    public int Value
    {
        get
        {
            return _value;
        }
        set
        {
            if (value < 0 || value >= _options.Count)
            {
                return;
            }

            var isChanged = value != _value;
            _value = value;
            if(isChanged) { Updated(); }
        }
    }

    public string ValueText => _options[_value];

    public DropDownList(string label, List<string> options, IDialogDirector director): base(director)
    {
        _options = options;
    }

    public void SetSelection(string text)
    {
        var index = _options.FindIndex(d => d == text);
        if (index == -1)
        {
            throw new InvalidOperationException($"Option {text} not found");
        }

        Value = index;
    }
}