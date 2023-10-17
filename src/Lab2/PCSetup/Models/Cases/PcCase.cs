using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Motherboards;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Cases;

public class PcCase
{
    public PcCase(int maximumVideoCardLength, ICollection<IMotherBoard> supportedFormFactors, int maximumCoolerHeight)
    {
        MaximumVideoCardLength = maximumVideoCardLength;
        SupportedFormFactors = supportedFormFactors;
        MaximumCoolerHeight = maximumCoolerHeight;
    }

    public int MaximumVideoCardLength { get; }
    public ICollection<IMotherBoard> SupportedFormFactors { get; }
    public int MaximumCoolerHeight { get; }
}