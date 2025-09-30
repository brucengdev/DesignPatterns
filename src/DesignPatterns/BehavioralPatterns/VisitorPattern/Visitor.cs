namespace VisitorPattern;

public abstract class Visitor
{
    public virtual void VisitCompositeEquipment(CompositeEquipment compositeEquipment) { }

    public virtual void VisitRam(Ram ram) { }

    public virtual void VisitPowerSupply(PowerSupply powerSupply) { }

    public virtual void VisitMotherboard(Motherboard motherboard) { }
    public virtual void VisitHardDrive(HardDrive hardDrive) { }
    public virtual void VisitCPU(CPU cpu) { }
    public virtual void VisitGPU(GPU gpu) { }
}