namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Deflectors;

public class DeflectorClassThree : Deflector
{
    public DeflectorClassThree(bool isPhoton)
        : base(isPhoton)
    {
        DestroyedAsteroids = ShipParameters.ThirdDeflectorsAsteroidsLimit;
        DestroyedMeteors = ShipParameters.ThirdDeflectorsMeteorsLimit;
        ReflectedWhales = ShipParameters.ThirdDeflectorsWhalesLimit;
    }

    public int ReflectedWhales { get; private set; }
}