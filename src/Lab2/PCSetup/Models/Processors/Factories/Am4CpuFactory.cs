using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Vendors.AMD;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Factories;

public class Am4CpuFactory : IProcessorFactory
{
    public IProcessor Create(
        string model,
        double coreFrequency,
        int coreCount,
        IntegratedGpu? integratedVideoCore,
        int maximumDdrFrequency,
        int tdp,
        int powerConsumption)
    {
        return new Am4Processor(
            model,
            coreFrequency,
            coreCount,
            integratedVideoCore,
            maximumDdrFrequency,
            tdp,
            powerConsumption);
    }
}