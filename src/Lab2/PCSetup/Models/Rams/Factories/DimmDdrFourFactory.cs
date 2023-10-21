namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams.Factories;

public class DimmDdrFourFactory : RamFactory
{
    private readonly IRamType _ddrFour = new DdrFourRam();
    public DimmDdrFourFactory(string name, int memorySize, int powerConsumption)
        : base(name, memorySize, powerConsumption)
    {
    }

    public override IPcComponent Create()
    {
        return new DimmFormFactor(Name, MemorySize, PowerConsumption, _ddrFour);
    }
}