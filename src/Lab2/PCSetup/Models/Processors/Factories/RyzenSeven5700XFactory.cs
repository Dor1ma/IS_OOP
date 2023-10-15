using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Vendors.AMD;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Factories;

public class RyzenSeven5700XFactory : IProcessorFactory
{
    public IProcessor Create()
    {
        return new RyzenSeven5700X();
    }
}