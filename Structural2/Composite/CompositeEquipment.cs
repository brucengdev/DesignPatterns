namespace Composite;

public class CompositeEquipment : Equipment
{
    public override float DiscountedPrice()
    {
        float result = 0;
        foreach(var equipment in _children)
        {
            result += equipment.DiscountedPrice();
        }
        return result;
    }

    public override float NetPrice()
    {
        float result = 0;
        foreach(var equipment in _children)
        {
            result += equipment.NetPrice();
        }
        return result;
    }

    public override int Power()
    {
        int result = 0;
        foreach(var equipment in _children)
        {
            result += equipment.Power();
        }
        return result;
    }

    private List<Equipment> _children = new();
    public override void AddEquipment(Equipment e)
    {
        _children.Add(e);
    }
}