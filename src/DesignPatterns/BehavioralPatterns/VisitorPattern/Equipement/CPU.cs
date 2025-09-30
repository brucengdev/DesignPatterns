namespace VisitorPattern;

public class CPU: Equipment
{
    public CPU(string name) : base(name)
    {
    }

    public override int Prize() => 100;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitCPU(this);
    }
}