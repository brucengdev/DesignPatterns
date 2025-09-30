namespace VisitorPattern;

public class VisitorTests
{
    [Fact]
    public void TestPricingVisitor()
    {
            var computer = CreateComputer();

            var pricingVisitor = new PricingVisitor();
            computer.Accept(pricingVisitor);
        
            Assert.Equal(540, pricingVisitor.TotalPrice);
    }
    
    [Fact]
    public void TestListingVisitor()
    {
        var computer = CreateComputer();

        var listingVisitor = new ListingVisitor();
        computer.Accept(listingVisitor);

        var expected = "Motherboard: Asus mobo, Price: 100\n" +
                       "Ram: Kingston ram, Price: 10\n" +
                       "Ram: Kingston ram, Price: 10\n" +
                       "CPU: Intel i7 Skylake, Price: 100\n" +
                       "GPU: NVIDIA GTX 1060, Price: 200\n" +
                       "HardDrive: Western Digital HDD, Price: 20\n" +
                       "PowerSupply: Coolermaster Power supply, Price: 100\n";
        var actual = listingVisitor.Listing.ReplaceLineEndings("\n");
        Assert.Equal(expected, actual);
    }

    private static Computer CreateComputer()
    {
        var computer = new Computer("Nguyen's computer");
        var motherboard = new Motherboard("Asus mobo");
        var ram1 = new Ram("Kingston ram");
        var ram2 = new Ram("Kingston ram");
        var cpu = new CPU("Intel i7 Skylake");
        var gpu = new GPU("NVIDIA GTX 1060");
        var harddrive = new HardDrive("Western Digital HDD");
        var powersupply = new PowerSupply("Coolermaster Power supply");
        var pcCase = new Case("Thermaltek case");
        
        //assemble
        var internals = new Internals("PC internals");
        internals.Add(motherboard);
        internals.Add(ram1);
        internals.Add(ram2);
        internals.Add(cpu);
        internals.Add(gpu);
        internals.Add(harddrive);
        
        pcCase.Add(internals);
        pcCase.Add(powersupply);
        
        computer.Add(pcCase);
        return computer;
    }
}