using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Vendors.Intel;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Factories;

public class Lga1700CpuFactory : ProcessorFactory
{
    public Lga1700CpuFactory(
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
        return new Lga1700Processor(
            Name,
            CoreCount,
            CoreCount,
            IntegratedVideoCore,
            MaximumDdrFrequency,
            Tdp,
            PowerConsumption);
    }
}