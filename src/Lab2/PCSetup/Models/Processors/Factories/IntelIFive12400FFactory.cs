using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Vendors.Intel;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Factories;

public class IntelIFive12400FFactory : IProcessorFactory
{
    public IProcessor Create()
    {
        return new IntelIFive12400F();
    }
}