using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages.SSDs.Instances;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages.SSDs.Factories;

public class KingstonA400SsdFactory : ISsdFactory
{
    public ISsd Create()
    {
        return new KingstonA400Ssd();
    }
}