namespace Composite.Equipement;

public class PowerSupply:Equipment
{
    public PowerSupply(string name) : base(name)
    {
    }

    public override int Prize() => 100;
}