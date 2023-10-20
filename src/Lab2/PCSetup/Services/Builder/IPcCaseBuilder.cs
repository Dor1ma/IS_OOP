using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Cases;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Services.Builder;

public interface IPcCaseBuilder
{
    IPcBuilder WithPcCase(PcCase pcCase);
}