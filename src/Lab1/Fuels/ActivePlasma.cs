namespace Itmo.ObjectOrientedProgramming.Lab1.Fuels;

public class ActivePlasma : Fuel
{
    private const int StandardActivePlasmaPrice = 10;
    public ActivePlasma()
    {
        Price = StandardActivePlasmaPrice;
    }
}