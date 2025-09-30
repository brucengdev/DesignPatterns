namespace VisitorPattern;

public class GPU: Equipment
{
    public GPU(string name) : base(name)
    {
    }

    public override int Prize() => 200;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitGPU(this);
    }
}