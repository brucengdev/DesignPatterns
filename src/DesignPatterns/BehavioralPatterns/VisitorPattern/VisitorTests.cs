namespace VisitorPattern;

public class VisitorTests
{
    [Fact]
    public void TestPricingVisitor()
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

            var pricingVisitor = new PricingVisitor();
            computer.Accept(pricingVisitor);
        
            Assert.Equal(540, pricingVisitor.TotalPrice);
    }
}