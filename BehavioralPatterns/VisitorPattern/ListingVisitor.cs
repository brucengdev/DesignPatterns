using System.Text;

namespace VisitorPattern;

public class ListingVisitor: Visitor
{
    private StringBuilder _listingSB = new();
    public string Listing => _listingSB.ToString();
    
    public override void VisitRam(Ram ram)
    {
        _listingSB.AppendLine($"Ram: {ram.Name}, Price: {ram.Prize()}");
    }

    public override void VisitPowerSupply(PowerSupply powerSupply)
    {
        _listingSB.AppendLine($"PowerSupply: {powerSupply.Name}, Price: {powerSupply.Prize()}");
    }

    public override void VisitMotherboard(Motherboard motherboard)
    {
        _listingSB.AppendLine($"Motherboard: {motherboard.Name}, Price: {motherboard.Prize()}");
    }

    public override void VisitHardDrive(HardDrive hardDrive)
    {
        _listingSB.AppendLine($"HardDrive: {hardDrive.Name}, Price: {hardDrive.Prize()}");
    }

    public override void VisitCPU(CPU cpu)
    {
        _listingSB.AppendLine($"CPU: {cpu.Name}, Price: {cpu.Prize()}");
    }

    public override void VisitGPU(GPU gpu)
    {
        _listingSB.AppendLine($"GPU: {gpu.Name}, Price: {gpu.Prize()}");
    }
}