using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Stella : Ship
{
    private readonly ImpulseEngine _impulseEngine = new ImpulseEngine('C');
    private readonly JumpEngine _jumpEngine = new JumpEngine("Omega");
    public Stella()
    {
        AsteroidsLimit = 1;
        MeteorsLimit = 0;
        DestroyedAsteroids = 2;
        DestroyedMeteors = 1;
        IsActive = true;
    }

    public override void Defence()
    {
        throw new System.NotImplementedException();
    }

    // TEMP FUNCTION
    public void Temp()
    {
        _impulseEngine.EngineType = 'C';
        _jumpEngine.EngineType = 'O';
    }
}