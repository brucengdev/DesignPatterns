namespace VisitorPattern;

public class PricingVisitor: Visitor
{
    private int _totalPrice = 0;
    public int TotalPrice => _totalPrice;
    public override void VisitCompositeEquipment(CompositeEquipment compositeEquipment)
    {
        throw new NotImplementedException();
    }
}