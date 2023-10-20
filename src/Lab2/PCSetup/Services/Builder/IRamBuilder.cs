using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Services.Builder;

public interface IRamBuilder
{
    IPcBuilder WithRam(Ram ram);
}