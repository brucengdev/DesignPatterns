namespace Memento;

public class Memento(string data)
{
    public string GetState() => data;
}