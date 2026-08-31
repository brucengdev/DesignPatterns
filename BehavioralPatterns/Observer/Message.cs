namespace Observer;

public class Message: IObserver
{
    private string _messageText;
    public string MessageText => _messageText;
    private TextBox _nameTextBox;
    private string _template;

    public Message(string template, TextBox nameTextBox)
    {
        _template = template;
        _nameTextBox = nameTextBox;
    }

    public void Update(Subject subject)
    {
        if (subject == _nameTextBox)
        {
            _messageText = _template.Replace("{name}", _nameTextBox.Text);
        }
    }
}