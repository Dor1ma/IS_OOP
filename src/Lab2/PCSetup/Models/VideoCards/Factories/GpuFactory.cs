namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards.Factories;

public class GpuFactory : IGpuFactory
{
    public IGpu Create(
        string name,
        int length,
        int width,
        int videoMemorySize,
        double pciExpressVersion,
        int chipFrequency,
        int powerConsumption)
    {
        return new Gpu(
            name,
            length,
            width,
            videoMemorySize,
            pciExpressVersion,
            chipFrequency,
            powerConsumption);
    }
}