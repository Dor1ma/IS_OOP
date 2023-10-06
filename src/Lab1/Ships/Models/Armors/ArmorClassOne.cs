namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Armors;

public class ArmorClassOne : Armor
{
    public ArmorClassOne()
    {
        AsteroidsLimit = ShipParameters.ArmorClassOneAsteroidsLimit;
        MeteorsLimit = ShipParameters.ArmorClassOneMeteorsLimit;
    }
}