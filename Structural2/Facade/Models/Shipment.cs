namespace Facade;

public record Shipment
{
    public string Product { get; set; }
    public int Quantity { get; set; }
    public string Customer { get; set; }
}