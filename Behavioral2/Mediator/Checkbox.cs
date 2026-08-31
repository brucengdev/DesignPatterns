namespace Mediator;

public class Checkbox: Control
{
    private bool _value = false;
    public bool Value => _value;
    public Checkbox(string label, bool value, IDialogDirector director): base(director)
    {
        _value = value;
    }
}