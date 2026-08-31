namespace Composite;

public class Motherboard : CompositeEquipment
{
    public override float DiscountedPrice()
    {
        return 100;
    }

    public override float NetPrice()
    {
        return 120;
    }

    public override int Power()
    {
        return 30;
    }
}