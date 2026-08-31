using Shouldly;

namespace Facade;

public class OnlineShoppingFacadeTests
{
    [Fact]
    public void TestOnlineShoppingFacade()
    {
        //arrange
        var application = new ShoppingApplication();
        var sut = application.GetOnlineShoppingFacade();
        //prepare test data
        application.Inventory.AddProduct(new()
        {
            Name = "HP Computer",
            Stock = 92,
            Price = 1200
        });
        application.Inventory.AddProduct(new()
        {
            Name = "Apple Macbooks",
            Stock = 30,
            Price = 2000
        });
        application.Payment.AddCard(new()
        {
            Name = "Tom",
            Balance = 2550
        });

        //act
        //This demonstrate the Facade to be a much simpler interface
        //compared to all the subsystems behind it.
        sut.PlaceOrder("Tom", "HP Computer", 2);

        //assert
        application.Inventory.GetProduct("HP Computer")!.Stock.ShouldBe(90);
        application.Payment.GetCard("Tom")!.Balance.ShouldBe(150);
        application.Shipping.Shipments.ShouldBe([
            new Shipment
            {
                Customer = "Tom",
                Product = "HP Computer",
                Quantity = 2
            }
        ]);
    }
}