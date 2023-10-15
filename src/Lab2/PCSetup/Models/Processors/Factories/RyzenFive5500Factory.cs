using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Vendors.AMD;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Factories;

public class RyzenFive5500Factory : IProcessorFactory
{
    public IProcessor Create()
    {
        return new RyzenFive5500();
    }
}