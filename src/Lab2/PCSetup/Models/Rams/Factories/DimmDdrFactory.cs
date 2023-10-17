namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams.Factories;

public class DimmDdrFactory : IRamFactory
{
    private readonly IRamType _ddrFour = new DdrFourRam();
    private readonly IRamType _ddrFive = new DdrFiveRam();

    public IRam CreateDdrFourthDdr(int memorySize, string formFactor, int powerConsumption)
    {
        return new DimmFormFactor(memorySize, formFactor, powerConsumption, _ddrFour);
    }

    public IRam CreateDdrFiveDdr(int memorySize, string formFactor, int powerConsumption)
    {
        return new DimmFormFactor(memorySize, formFactor, powerConsumption, _ddrFive);
    }
}