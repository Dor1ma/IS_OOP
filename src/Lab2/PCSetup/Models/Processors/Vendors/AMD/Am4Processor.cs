using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Vendors.AMD;

public class Am4Processor : Processor
{
    public Am4Processor(
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

    public override Processor Clone()
    {
        return new Am4Processor(
            (string)Name.Clone(),
            CoreFrequency,
            CoreCount,
            IntegratedVideoCore,
            MaximumDdrFrequency,
            Tdp,
            PowerConsumption);
    }
}