namespace Facade;

public class ShoppingApplication
{
    public Inventory Inventory { get; set; } = new();
    public Payment Payment { get; set; } = new();
    public Shipping Shipping { get; set; } = new();

    public OnlineShoppingFacade GetOnlineShoppingFacade()
    {
        return new OnlineShoppingFacade(Inventory, Payment, Shipping);
    }
}