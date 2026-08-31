namespace Proxy;

/// <summary>
/// Real product
/// </summary>
public class Product: IProduct
{
    public Product(string fileName, FileContentLoader loader)
    {
        var lines = loader.ReadLines(fileName);
        using var enumerator = lines.GetEnumerator();
        enumerator.MoveNext();
        Name = enumerator.Current;
        enumerator.MoveNext();
        Description = enumerator.Current;
    }
    public string Name { get; }
    public string Description { get; }
}