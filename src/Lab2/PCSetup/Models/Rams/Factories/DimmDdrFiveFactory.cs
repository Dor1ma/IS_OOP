namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams.Factories;

public class DimmDdrFiveFactory : RamFactory
{
    private readonly IRamType _ddrFive = new DdrFiveRam();
    public DimmDdrFiveFactory(string name, int memorySize, int powerConsumption)
        : base(name, memorySize, powerConsumption)
    {
    }

    public override IPcComponent Create()
    {
        return new SoDimmFormFactor(Name, MemorySize, PowerConsumption, _ddrFive);
    }
}