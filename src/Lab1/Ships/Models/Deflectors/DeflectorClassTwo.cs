namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

public class DeflectorClassTwo : Deflector
{
    public DeflectorClassTwo(bool isPhoton)
        : base(isPhoton)
    {
        DestroyedAsteroids = ShipParameters.SecondDeflectorsAsteroidsLimit;
        DestroyedMeteors = ShipParameters.SecondDeflectorsMeteorsLimit;
    }
}