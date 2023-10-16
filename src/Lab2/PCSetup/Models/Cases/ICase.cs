using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Cases;

public interface ICase
{
    public int MaximumVideoCardLength { get; }
    public ICollection<string> SupportedFormFactors { get; }
    public int MaximumCoolerHeight { get; }
}