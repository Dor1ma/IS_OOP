using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Motherboards;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Cases.Factories;

public class PcCaseFactory : IPcComponentFactory
{
    private readonly int _maximumVideoCardLength;
    private readonly ICollection<MotherBoard> _supportedFormFactors;
    private readonly int _maximumCoolerHeight;
    private readonly string _name;
    public PcCaseFactory(
        string name,
        int maximumVideoCardLength,
        ICollection<MotherBoard> supportedFormFactors,
        int maximumCoolerHeight)
    {
        _name = name;
        _maximumVideoCardLength = maximumVideoCardLength;
        _supportedFormFactors = supportedFormFactors;
        _maximumCoolerHeight = maximumCoolerHeight;
    }

    public IPcComponent Create()
    {
        return new PcCase(_name, _maximumVideoCardLength, _supportedFormFactors, _maximumCoolerHeight);
    }
}