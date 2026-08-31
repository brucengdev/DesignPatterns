namespace Composite;

public class PCCase: CompositeEquipment
{
    private float _casePrice;
    private float _discount;
    private int _power;

    public PCCase(float casePrice, float discount, int power)
    {
        _casePrice = casePrice;
        _discount = discount;
        _power = power;
    }
    public override float DiscountedPrice()
    {
        return base.DiscountedPrice() + _casePrice * _discount;
    }

    public override float NetPrice()
    {
        return base.NetPrice() + _casePrice;
    }

    public override int Power()
    {
        return base.Power() + _power;
    }
}