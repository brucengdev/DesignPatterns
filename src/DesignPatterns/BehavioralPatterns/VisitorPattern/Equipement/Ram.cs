namespace VisitorPattern;

public class Ram: Equipment
{
    public Ram(string name) : base(name)
    {
    }

    public override int Prize() => 10;
}