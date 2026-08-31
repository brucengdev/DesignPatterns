namespace Composite.Equipement;

public class HardDrive: Equipment
{
    public HardDrive(string name) : base(name)
    {
    }

    public override int Prize() => 20;
}