namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards.Factories;

public class DiscreteGpuFactory : IGpuFactory
{
    public Gpu Create(
        string name,
        int length,
        int width,
        int videoMemorySize,
        double pciExpressVersion,
        int chipFrequency,
        int powerConsumption)
    {
        return new DiscreteGpu(
            name,
            length,
            width,
            videoMemorySize,
            pciExpressVersion,
            chipFrequency,
            powerConsumption);
    }
}