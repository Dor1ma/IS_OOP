using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Vendors.AMD;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Factories;

public class Am4CpuFactory : ProcessorFactory
{
    public Am4CpuFactory(
        string name,
        double coreFrequency,
        int coreCount,
        IntegratedGpu? integratedVideoCore,
        int maximumDdrFrequency,
        int tdp,
        int powerConsumption)
        : base(name, coreFrequency, coreCount, integratedVideoCore, maximumDdrFrequency, tdp, powerConsumption)
    {
    }

    public override IPcComponent Create()
    {
        return new Am4Processor(
            Name,
            CoreFrequency,
            CoreCount,
            IntegratedVideoCore,
            MaximumDdrFrequency,
            Tdp,
            PowerConsumption);
    }
}