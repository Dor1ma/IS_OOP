namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

public class ArmorClassOne : Armor
{
    public ArmorClassOne()
    {
        AsteroidsLimit = ShipParameters.ArmorClassOneAsteroidsLimit;
        MeteorsLimit = ShipParameters.ArmorClassOneMeteorsLimit;
    }
}