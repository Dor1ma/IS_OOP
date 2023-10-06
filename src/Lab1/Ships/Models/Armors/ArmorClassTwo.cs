namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Armors;

public class ArmorClassTwo : Armor
{
    public ArmorClassTwo()
    {
        AsteroidsLimit = ShipParameters.ArmorClassTwoAsteroidsLimit;
        MeteorsLimit = ShipParameters.ArmorClassTwoMeteorsLimit;
    }
}