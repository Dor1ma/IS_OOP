namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams.Factories;

public interface IRamFactory
{
    Ram CreateDdrFourthDdr(string name, int memorySize, int powerConsumption);
    Ram CreateDdrFiveDdr(string name, int memorySize, int powerConsumption);
}