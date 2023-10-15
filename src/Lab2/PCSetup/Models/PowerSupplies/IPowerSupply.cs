namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.PowerSupplies;

public interface IPowerSupply
{
    public int PeakLoad { get; protected init; }
}