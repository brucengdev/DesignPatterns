namespace Composite;

public class CompositeTests
{
    [Fact]
    public void TestComposite()
    {
        var pc = new PCCase(50, 0.8f, 0);
        var motherboard = new Motherboard();
        var cpu = new CPU();
        var harddrive = new Harddrive();

        motherboard.AddEquipment(cpu);
        motherboard.AddEquipment(harddrive);
        pc.AddEquipment(motherboard);

        Assert.Equal(170, pc.NetPrice());
        Assert.Equal(140, pc.DiscountedPrice());
        Assert.Equal(30, pc.Power());
    }
}
