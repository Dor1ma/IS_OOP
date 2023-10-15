using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Vendors.Intel;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Factories;

public class IntelISeven13700KfFactory : IProcessorFactory
{
    public IProcessor Create()
    {
        return new IntelISeven13700KF();
    }
}