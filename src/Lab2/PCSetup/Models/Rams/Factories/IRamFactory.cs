namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams.Factories;

public interface IRamFactory
{
    IRam CreateDdrFourthDdr(string name, int memorySize, int powerConsumption);
    IRam CreateDdrFiveDdr(string name, int memorySize, int powerConsumption);
}