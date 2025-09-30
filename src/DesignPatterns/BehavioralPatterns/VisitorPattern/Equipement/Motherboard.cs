namespace VisitorPattern;

public class Motherboard: Equipment
{
    public Motherboard(string name) : base(name)
    {
    }

    public override int Prize() => 100;
}