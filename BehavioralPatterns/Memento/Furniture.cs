namespace Memento;

public class Furniture
{
    public int X { get; set; }
    public int Y { get; set; }

    public Arrow Arrow { get; } = new();
}