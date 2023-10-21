namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards.Factories;

public class DiscreteGpuFactory : GpuFactory
{
    public DiscreteGpuFactory(
        string name,
        int length,
        int width,
        int videoMemorySize,
        double pciExpressVersion,
        int chipFrequency,
        int powerConsumption)
        : base(name, length, width, videoMemorySize, pciExpressVersion, chipFrequency, powerConsumption)
    {
    }

    public override IPcComponent Create()
    {
        return new DiscreteGpu(
            Name,
            Length,
            Width,
            VideoMemorySize,
            PciExpressVersion,
            ChipFrequency,
            PowerConsumption);
    }
}