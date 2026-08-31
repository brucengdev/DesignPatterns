namespace Flyweight;

public class PurchasingListTests
{
    [Fact]
    public async Task TestPurchasingList()
    {
        //arrange
        var catalog = new ProductCatalog();

        var purchases = new PurchaseList(catalog);

        purchases.Add("HP Omen", 2, "Accounting");
        purchases.Add("Macbook Pro", 3, "Business Analyst department");
        purchases.Add("Surface Pro", 5, "IT department");
        purchases.Add("Macbook Pro", 12, "Engineering");
        purchases.Add("HP Omen", 5, "Sales");

        var purchaseListString = purchases.Print();
        await Verify(purchaseListString);
    }
}