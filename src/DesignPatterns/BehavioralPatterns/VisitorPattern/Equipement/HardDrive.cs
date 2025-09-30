namespace VisitorPattern;

public class HardDrive: Equipment
{
    public HardDrive(string name) : base(name)
    {
    }

    public override int Prize() => 20;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitHardDrive(this);
    }
}