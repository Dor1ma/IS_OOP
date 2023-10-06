namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Armors;

public class ArmorClassThree : Armor
{
    public ArmorClassThree()
    {
        AsteroidsLimit = ShipParameters.ArmorClassThreeAsteroidsLimit;
        MeteorsLimit = ShipParameters.ArmorClassThreeMeteorsLimit;
    }
}