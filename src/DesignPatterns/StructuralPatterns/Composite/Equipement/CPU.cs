namespace Composite.Equipement;

public class CPU: Equipment
{
    public CPU(string name) : base(name)
    {
    }

    public override int Prize() => 100;
}