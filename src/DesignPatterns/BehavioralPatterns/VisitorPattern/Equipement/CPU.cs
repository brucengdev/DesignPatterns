namespace VisitorPattern;

public class CPU: Equipment
{
    public CPU(string name) : base(name)
    {
    }

    public override int Prize() => 100;
}