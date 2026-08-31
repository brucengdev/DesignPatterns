using System.Text;

namespace Flyweight;

public class PurchaseList
{
    private ProductCatalog _catalog;
    private List<Purchase> _purchases = new();

    public PurchaseList(ProductCatalog catalog)
    {
        _catalog = catalog;
    }

    public void Add(string productName, int quantity, string department)
    {
        var product = _catalog.GetProduct(productName);
        _purchases.Add(new Purchase()
        {
            Quantity = quantity,
            Product = product,
            Department = department
        });
    }

    public string Print()
    {
        var sb = new StringBuilder();
        sb.AppendLine("Purchases:");
        sb.AppendLine("=====================================");
        foreach (var p in _purchases)
        {
            sb.AppendLine($"{p.Product.Brand} - {p.Product.Name}");
            sb.AppendLine($"{p.Product.Description}");
            sb.AppendLine($"Quantity: {p.Quantity}, For department: {p.Department}");
            sb.AppendLine("-------------");
        }
        sb.AppendLine("=====================================");
        return sb.ToString();
    }
}