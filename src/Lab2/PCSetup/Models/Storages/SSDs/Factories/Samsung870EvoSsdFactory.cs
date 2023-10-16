using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages.SSDs.Instances;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages.SSDs.Factories;

public class Samsung870EvoSsdFactory : ISsdFactory
{
    public ISsd Create()
    {
        return new Samsung870EvoSsd();
    }
}