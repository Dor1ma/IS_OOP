using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Vendors.Intel;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Factories;

public class Lga1700CpuFactory : IProcessorFactory
{
    public IProcessor Create(
        string model,
        double coreFrequency,
        int coreCount,
        IIntegratedGpu? integratedVideoCore,
        int maximumDdrFrequency,
        int tdp,
        int powerConsumption)
    {
        return new Lga1700Processor(
            model,
            coreFrequency,
            coreCount,
            integratedVideoCore,
            maximumDdrFrequency,
            tdp,
            powerConsumption);
    }
}