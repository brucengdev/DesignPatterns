using Shouldly;

namespace Proxy;

public class ProxyTests
{
    [Fact]
    public async Task TestVirtualProxy_only_requested_files_are_read()
    {
        var loader = new FileContentLoader();
        var products = CreateProductList(loader);

        var productListing = new ProductListing(products);

        await Verify(productListing.CompileTextListing([0, 1]));

        loader.ReadFiles.ShouldBe([
            "ProductFiles/HP Omen.txt",
            "ProductFiles/Macbook Pro.txt"
        ]);
    }
    
    [Fact]
    public async Task TestVirtualProxy_only_requested_files_are_read_2()
    {
        var loader = new FileContentLoader();
        var products = CreateProductList(loader);

        var productListing = new ProductListing(products);

        await Verify(productListing.CompileTextListing([2]));

        loader.ReadFiles.ShouldBe([
            "ProductFiles/Surface Pro.txt"
        ]);
    }

    private static List<IProduct> CreateProductList(FileContentLoader loader)
    {
        List<IProduct> products =
        [
            new ProxyProduct("ProductFiles/HP Omen.txt", loader),
            new ProxyProduct("ProductFiles/Macbook Pro.txt", loader),
            new ProxyProduct("ProductFiles/Surface Pro.txt", loader)
        ];
        return products;
    }
}