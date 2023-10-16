using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards.Instances;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards.Factories;

public class MsiRtx4060Ventus3XFactory : IGpuFactory
{
    public IGpu Create()
    {
        return new MsiRtx4060Ventus3X();
    }
}