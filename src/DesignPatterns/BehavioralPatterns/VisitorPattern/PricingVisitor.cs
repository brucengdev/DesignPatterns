namespace VisitorPattern;

public class PricingVisitor: Visitor
{
    private int _totalPrice = 0;
    public int TotalPrice => _totalPrice;

    public override void VisitRam(Ram ram)
    {
        _totalPrice += ram.Prize();
    }

    public override void VisitPowerSupply(PowerSupply powerSupply)
    {
        _totalPrice += powerSupply.Prize();
    }

    public override void VisitMotherboard(Motherboard motherboard)
    {
        _totalPrice += motherboard.Prize();
    }

    public override void VisitHardDrive(HardDrive hardDrive)
    {
        _totalPrice += hardDrive.Prize();
    }

    public override void VisitCPU(CPU cpu)
    {
        _totalPrice += cpu.Prize();
    }

    public override void VisitGPU(GPU gpu)
    {
        _totalPrice += gpu.Prize();
    }
}