using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.CoolingSystems;

public interface ICooller
{
    public int Height { get; protected init; }
    public ICollection<IProcessor> SupportedSockets { get; protected init; }
    public int MaximumTdp { get; protected init; }
}