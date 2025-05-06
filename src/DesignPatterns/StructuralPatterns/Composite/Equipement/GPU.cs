namespace Composite.Equipement;

public class GPU: Equipment
{
    public GPU(string name) : base(name)
    {
    }

    public override int Prize() => 200;
}