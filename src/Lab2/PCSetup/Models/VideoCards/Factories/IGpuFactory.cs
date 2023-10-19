namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards.Factories;

public interface IGpuFactory
{
    Gpu Create(
        string name,
        int length,
        int width,
        int videoMemorySize,
        double pciExpressVersion,
        int chipFrequency,
        int powerConsumption);
}