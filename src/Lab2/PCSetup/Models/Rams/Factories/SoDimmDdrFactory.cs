namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams.Factories;

public class SoDimmDdrFactory : IRamFactory
{
    private readonly IRamType _ddrFour = new DdrFourRam();
    private readonly IRamType _ddrFive = new DdrFiveRam();

    public Ram CreateDdrFourthDdr(string name, int memorySize, int powerConsumption)
    {
        return new SoDimmFormFactor(name, memorySize, powerConsumption, _ddrFour);
    }

    public Ram CreateDdrFiveDdr(string name, int memorySize, int powerConsumption)
    {
        return new SoDimmFormFactor(name, memorySize, powerConsumption, _ddrFive);
    }
}