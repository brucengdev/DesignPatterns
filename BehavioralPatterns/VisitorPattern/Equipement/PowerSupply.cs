namespace VisitorPattern;

public class PowerSupply:Equipment
{
    public PowerSupply(string name) : base(name)
    {
    }

    public override int Prize() => 100;

    public override void Accept(Visitor visitor)
    {
        visitor.VisitPowerSupply(this);
    }
}