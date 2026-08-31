namespace Command;

public class Document
{
    private string _text = "";
    public string Text => _text;

    public void AppendText(string text)
    {
        _text += text;
    }

    public void Save()
    {
        File.WriteAllText("document.txt", _text);
    }
}