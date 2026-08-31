namespace Facade;

public class OnlineShoppingFacade
{
    private Inventory _inventory;
    private Payment _payment;
    private Shipping _shipping;
    public OnlineShoppingFacade(Inventory inventory, Payment payment, Shipping shipping)
    {
        _inventory = inventory;
        _payment = payment;
        _shipping = shipping;
    }

    public void PlaceOrder(string customer, string product, int quantity)
    {
        _inventory.Deduct(product, quantity);
        _payment.Charge(customer, _inventory.GetPrice(product, quantity));
        _shipping.Ship(customer, product, quantity);
    }
}