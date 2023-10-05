namespace Itmo.ObjectOrientedProgramming.Lab1;

public class FuelExchange
{
    public FuelExchange(int activePlasmaCost, int gravityMatterCost)
    {
        ActivePlasmaCost = activePlasmaCost;
        GravityMatterCost = gravityMatterCost;
    }

    public int ActivePlasmaCost { get; }
    public int GravityMatterCost { get; }
}