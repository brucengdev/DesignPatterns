namespace Facade;

public class Shipping
{
    private List<Shipment> _shipments = new();
    public IReadOnlyCollection<Shipment> Shipments => _shipments.AsReadOnly();

    public void Ship(string customer, string product, int quantity)
    {
        _shipments.Add(new()
        {
            Customer = customer,
            Product = product,
            Quantity = quantity
        });
    }
}