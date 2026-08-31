namespace Composite;

public abstract class Equipment
{
    public abstract int Power();
    public abstract float NetPrice();
    public abstract float DiscountedPrice();

    public virtual void AddEquipment(Equipment e)
    {
        throw new NotSupportedException("Cannot add equipement");
    }
}