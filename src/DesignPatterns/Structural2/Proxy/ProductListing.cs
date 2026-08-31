using System.Text;

namespace Proxy;

public class ProductListing(List<IProduct> products)
{
    public string CompileTextListing(List<int> productIndices)
    {
        var sb = new StringBuilder();
        foreach (var productIndex in productIndices)
        {
            var product = products[productIndex];
            sb.AppendLine($"Product #{productIndex}");
            sb.AppendLine($"Name: {product.Name} Description: {product.Description}");
        }

        return sb.ToString();
    }
}