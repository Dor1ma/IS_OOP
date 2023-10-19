using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Vendors.Intel;

public class Lga1700Processor : Processor
{
    public Lga1700Processor(
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
        return new Lga1700Processor(
            (string)Name.Clone(),
            CoreFrequency,
            CoreCount,
            IntegratedVideoCore,
            MaximumDdrFrequency,
            Tdp,
            PowerConsumption);
    }
}