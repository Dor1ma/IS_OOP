using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Vaklas : Ship
{
    private readonly ImpulseEngine _impulseEngine = new ImpulseEngine('E');
    private readonly JumpEngine _jumpEngine = new JumpEngine("Gamma");
    public Vaklas()
    {
        AsteroidsLimit = 5;
        MeteorsLimit = 2;
        DestroyedAsteroids = 2;
        DestroyedMeteors = 1;
        ReflectedWhales = 0;
        IsActive = true;
    }

    public bool Active { get; set; } = true;
    public override void Defence()
    {
        if (DestroyedAsteroids == 2 || DestroyedMeteors == 1)
        {
            Active = false;
        }
        else
        {
            DestroyedAsteroids++; // temp
        }
    }

    // TEMP FUNCTION
    public void Temp()
    {
        _impulseEngine.Speed = 'c';
        _jumpEngine.EngineType = 'G';
    }
}