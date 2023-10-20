using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Motherboards;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Services.Builder;

public interface IMotherBoardBuilder
{
    IPcBuilder WithMotherBoard(MotherBoard motherBoard);
}