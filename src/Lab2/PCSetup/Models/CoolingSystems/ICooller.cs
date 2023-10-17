namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.CoolingSystems;

public interface ICooller
{
    // Don't forget to implement the supportable processor list!
    public int Height { get; protected init; }
    public int MaximumTdp { get; protected init; }
}