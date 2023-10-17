namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams.Factories;

public interface IRamFactory
{
    IRam CreateDdrFourthDdr(int memorySize, string formFactor, int powerConsumption);
    IRam CreateDdrFiveDdr(int memorySize, string formFactor, int powerConsumption);
}