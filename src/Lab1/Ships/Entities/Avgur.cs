using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Avgur : Ship
{
    private readonly ImpulseEngine _impulseEngine = new ImpulseEngine('E');
    private readonly JumpEngine _jumpEngine = new JumpEngine("Alpha");
    public Avgur()
    {
        DeflectorClass = 3;
        AsteroidsLimit = 20;
        MeteorsLimit = 5;
        DestroyedAsteroids = 40;
        DestroyedAsteroids = 10;
        ReflectedWhales = 1;
        IsActive = true;
    }

    public override void Defence()
    {
        throw new System.NotImplementedException();
    }

    // TEMP FUNCTION
    public void Temp()
    {
        _impulseEngine.EngineType = 'E';
        _jumpEngine.EngineType = 'A';
    }
}