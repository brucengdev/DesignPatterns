namespace Memento;

public class TextField
{
    private string _data = "";
    public void SetValue(string data)
    {
        _data = data;
    }

    public string Value => _data;

    public Memento GetMemento()
    {
        return new(_data);
    }

    public void SetMemento(Memento memento)
    {
        _data = memento.GetState();
    }
}