namespace Flyweight;

/// <summary>
/// This is the flyweight factory
/// </summary>
public class ProductCatalog
{
    private Dictionary<string, Product> _products = new();

    public ProductCatalog()
    {
        //for simplicity, hardcode the catalog here
        _products["HP Omen"] = new()
        {
            Name = "HP Omen",
            Description = "Powerful gaming laptop from HP",
            Brand = "HP"
        };
        _products["Macbook Pro"] = new()
        {
            Name = "Macbook Pro",
            Description = "The pro version of the Macbook computer line",
            Brand = "Apple"
        };
        _products["Surface Pro"] = new()
        {
            Name = "Surface Pro",
            Description = "Ultra portable 2 in 1 computers",
            Brand = "Microsoft"
        };
    }
    public Product GetProduct(string productName)
    {
        return _products[productName];
    }
}