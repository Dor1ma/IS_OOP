namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Deflectors;

public class DeflectorClassTwo : Deflector
{
    public DeflectorClassTwo(bool isPhoton)
        : base(isPhoton)
    {
        DestroyedAsteroids = ShipParameters.SecondDeflectorsAsteroidsLimit;
        DestroyedMeteors = ShipParameters.SecondDeflectorsMeteorsLimit;
    }
}