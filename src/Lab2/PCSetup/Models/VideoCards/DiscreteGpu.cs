namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards;

public class DiscreteGpu : Gpu
{
    public DiscreteGpu(
        string name,
        int length,
        int width,
        int videoMemorySize,
        double pciExpressVersion,
        int chipFrequency,
        int powerConsumption)
        : base(
            name,
            length,
            width,
            videoMemorySize,
            pciExpressVersion,
            chipFrequency,
            powerConsumption)
    {
    }

    public override Gpu Clone()
    {
        return new DiscreteGpu(
            (string)Name.Clone(),
            Length,
            Width,
            VideoMemorySize,
            PciExpressVersion,
            ChipFrequency,
            PowerConsumption);
    }
}