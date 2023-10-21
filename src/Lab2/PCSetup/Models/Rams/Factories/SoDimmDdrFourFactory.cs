namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams.Factories;

public class SoDimmDdrFourFactory : RamFactory
{
    private readonly IRamType _ddrFour = new DdrFourRam();
    public SoDimmDdrFourFactory(string name, int memorySize, int powerConsumption)
        : base(name, memorySize, powerConsumption)
    {
    }

    public override IPcComponent Create()
    {
        return new SoDimmFormFactor(Name, MemorySize, PowerConsumption, _ddrFour);
    }
}