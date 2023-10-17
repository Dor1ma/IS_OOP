using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Motherboards;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Cases.Factories;

public class PcCaseFactory
{
    private readonly int _maximumVideoCardLength;
    private readonly ICollection<IMotherBoard> _supportedFormFactors;
    private readonly int _maximumCoolerHeight;
    public PcCaseFactory(
        int maximumVideoCardLength,
        ICollection<IMotherBoard> supportedFormFactors,
        int maximumCoolerHeight)
    {
        _maximumVideoCardLength = maximumVideoCardLength;
        _supportedFormFactors = supportedFormFactors;
        _maximumCoolerHeight = maximumCoolerHeight;
    }

    public PcCase Create()
    {
        return new PcCase(_maximumVideoCardLength, _supportedFormFactors, _maximumCoolerHeight);
    }
}