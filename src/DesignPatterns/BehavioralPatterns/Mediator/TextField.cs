namespace Mediator;

public class TextField: Widget
{
    private string _text = "";
    private DialogDirector _director;
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

    public TextField(string label, DialogDirector director)
    {
        _director = director;
    }
}