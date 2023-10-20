using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.CoolingSystems;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Services.Builder;

public interface ICoolingSystemBuilder
{
    IPcBuilder WithCoolingSystem(Cooler cooler);
}