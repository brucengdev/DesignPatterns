namespace Mediator;

public class TextField: Widget
{
    private string _text = "";
    private IDialogDirector _director;
    public string Text
    {
        get
        {
            return _text;
        }
        set
        {
            if (_text == value)
            {
                return;
            }
            _text = value;
            _director.WidgetChanged(this);
        }
    }

    public TextField(string label, IDialogDirector director)
    {
        _director = director;
    }
}