using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Meredian : Ship
{
    private readonly ImpulseEngine _impulseEngine = new ImpulseEngine('E');
    public Meredian()
    {
        DeflectorClass = 2;
        AsteroidsLimit = 5;
        MeteorsLimit = 2;
        DestroyedAsteroids = 10;
        DestroyedMeteors = 3;
        ReflectedWhales = 0;
        IsActive = true;
    }

    // DON'T FORGET TO ADD ANTI-NITRINIUM EMITTER!!!
    public override void Defence()
    {
        throw new System.NotImplementedException();
    }

    // TEMP FUNCTION
    public void Temp()
    {
        _impulseEngine.EngineType = 'E';
    }
}