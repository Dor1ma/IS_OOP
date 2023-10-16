using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages.HDDs.Instances;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages.HDDs.Factories;

public class SeagateBaracudaHddFactory : IHddFactory
{
    public IHdd Create()
    {
        return new SeagateBaracudaHdd();
    }
}