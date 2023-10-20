using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.PowerSupplies;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Services.Builder;

public interface IPowerSupplyBuilder
{
    IPcBuilder WithPowerSupply(PowerSupply powerSupply);
}