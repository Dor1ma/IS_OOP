using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards.Instances;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards.Factories;

public class MsiRtx3060GamingXFactory : IGpuFactory
{
    public IGpu Create()
    {
        return new MsiRtx3060GamingX();
    }
}