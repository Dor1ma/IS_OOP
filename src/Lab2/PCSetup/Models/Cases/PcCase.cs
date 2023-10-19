using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Motherboards;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Cases;

public class PcCase : IPcComponent
{
    public PcCase(string name, int maximumVideoCardLength, ICollection<MotherBoard> supportedFormFactors, int maximumCoolerHeight)
    {
        Name = name;
        MaximumVideoCardLength = maximumVideoCardLength;
        SupportedFormFactors = supportedFormFactors;
        MaximumCoolerHeight = maximumCoolerHeight;
    }

    public string Name { get; private set; }
    public int MaximumVideoCardLength { get; private set; }
    public ICollection<MotherBoard> SupportedFormFactors { get; private set; }
    public int MaximumCoolerHeight { get; private set; }

    public PcCase Clone()
    {
        return new PcCase((string)Name.Clone(), MaximumVideoCardLength, SupportedFormFactors, MaximumCoolerHeight);
    }

    public PcCase ChangeName(string newName)
    {
        PcCase clone = Clone();
        clone.Name = newName;
        return clone;
    }

    public PcCase ChangeMaximumVideoCardLength(int newVideoCardLength)
    {
        PcCase clone = Clone();
        clone.MaximumVideoCardLength = newVideoCardLength;
        return clone;
    }

    public PcCase ChangeSupportedFormFactors(ICollection<MotherBoard> newSupportedFormFactors)
    {
        PcCase clone = Clone();
        clone.SupportedFormFactors = newSupportedFormFactors;
        return clone;
    }

    public PcCase ChangeMaximumCoolerHeight(int newMaximumCoolerHeight)
    {
        PcCase clone = Clone();
        clone.MaximumCoolerHeight = newMaximumCoolerHeight;
        return clone;
    }
}