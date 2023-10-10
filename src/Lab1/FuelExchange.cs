using Itmo.ObjectOrientedProgramming.Lab1.Fuels;

namespace Itmo.ObjectOrientedProgramming.Lab1;

public class FuelExchange
{
    public FuelExchange()
    {
        ActivePlasma = new ActivePlasma();
        GravitonMatter = new GravitonMatter();
    }

    public ActivePlasma ActivePlasma { get; private set; }
    public GravitonMatter GravitonMatter { get; private set; }
}