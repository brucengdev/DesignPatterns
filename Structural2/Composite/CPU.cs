using Composite;

public class CPU : Equipment
{
    public override float DiscountedPrice()
    {
        return 300;
    }

    public override float NetPrice()
    {
        return 350;
    }

    public override int Power()
    {
        return 65;
    }
}