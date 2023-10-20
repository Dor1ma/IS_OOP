using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Services.Builder;

public interface IVideoCardBuilder
{
    IPcBuilder WithVideoCard(DiscreteGpu discreteGpu);
}