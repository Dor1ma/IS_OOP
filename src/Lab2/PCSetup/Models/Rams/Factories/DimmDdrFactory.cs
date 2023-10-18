namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams.Factories;

public class DimmDdrFactory : IRamFactory
{
    private readonly IRamType _ddrFour = new DdrFourRam();
    private readonly IRamType _ddrFive = new DdrFiveRam();

    public IRam CreateDdrFourthDdr(string name, int memorySize, int powerConsumption)
    {
        return new DimmFormFactor(name, memorySize, powerConsumption, _ddrFour);
    }

    public IRam CreateDdrFiveDdr(string name, int memorySize, int powerConsumption)
    {
        return new DimmFormFactor(name, memorySize, powerConsumption, _ddrFive);
    }
}