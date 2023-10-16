using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.BiosDirectory;

public interface IBios
{
    public int BiosType { get; }
    public int Version { get; }
    public ICollection<IProcessor> SupportableProcessor { get; }
}