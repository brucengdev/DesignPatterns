namespace Command;

public class MenuItem
{
    private string _key = "";
    public string Key => _key;
    private ICommand _command;
    public MenuItem(string key, ICommand command)
    {
        _key = key;
        _command = command;
    }

    public void Click()
    {
        _command.Execute();
    }
}