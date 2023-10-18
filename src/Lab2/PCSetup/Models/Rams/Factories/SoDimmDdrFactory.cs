namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams.Factories;

public class SoDimmDdrFactory : IRamFactory
{
    private readonly IRamType _ddrFour = new DdrFourRam();
    private readonly IRamType _ddrFive = new DdrFiveRam();

    public IRam CreateDdrFourthDdr(string name, int memorySize, string formFactor, int powerConsumption)
    {
        return new SoDimmFormFactor(name, memorySize, formFactor, powerConsumption, _ddrFour);
    }

    public IRam CreateDdrFiveDdr(string name, int memorySize, string formFactor, int powerConsumption)
    {
        return new SoDimmFormFactor(name, memorySize, formFactor, powerConsumption, _ddrFive);
    }
}