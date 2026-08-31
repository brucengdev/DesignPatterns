namespace Facade;

public class Inventory
{
    private List<Product> _products = new();
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public Product? GetProduct(string name)
    {
        return _products.FirstOrDefault(p => p.Name == name);
    }

    public void Deduct(string name, int quantity)
    {
        var product = GetProduct(name);
        if (product == null)
        {
            return;
        }

        product.Stock -= quantity;
    }

    public int GetPrice(string name, int quantity)
    {
        var product = GetProduct(name);
        if (product == null)
        {
            return 0;
        }

        return product.Price * quantity;
    }
}