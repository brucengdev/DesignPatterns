namespace Observer;

public class TextBox: Subject
{
    private string _text;
    public string Text => _text;
    public void SetText(string text)
    {
        _text = text;
        Notify();
    }
}