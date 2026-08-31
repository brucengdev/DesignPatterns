namespace Proxy;

/// <summary>
/// The proxy makes sure that the real product is only created
/// and the file is read when the data is accessed.
/// Making resource loading on-demand.
/// </summary>
/// <param name="fileName"></param>
public class ProxyProduct(string fileName, FileContentLoader loader) : IProduct
{
    private void CreateRealProductIfNotCreated()
    {
        if (_realProduct == null)
        {
            _realProduct = new Product(fileName, loader);
        }
    }

    private Product _realProduct;
    public string Name {
        get
        {
            CreateRealProductIfNotCreated();
            return _realProduct.Name;
        }
    }

    public string Description
    {
        get
        {
            CreateRealProductIfNotCreated();
            return _realProduct.Description;
        }
    }
}