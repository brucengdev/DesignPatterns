namespace Composite;

public class Harddrive : Equipment
{

    public override float DiscountedPrice()
    {
        return 98;
    }

    public override float NetPrice()
    {
        return 100;
    }

    public override int Power()
    {
        return 10;
    }
}