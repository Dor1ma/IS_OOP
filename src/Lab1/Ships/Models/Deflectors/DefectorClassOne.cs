namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Deflectors;

public class DefectorClassOne : Deflector
{
    public DefectorClassOne(bool isPhoton)
    : base(isPhoton)
    {
        DestroyedAsteroids = ShipParameters.FirstDeflectorsAsteroidsLimit;
        DestroyedMeteors = ShipParameters.FirstDeflectorsMeteorsLimit;
    }
}