using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Avgur : Ship
{
    private readonly ImpulseEngine _impulseEngine = new ImpulseEngine('E');
    private readonly JumpEngine _jumpEngine = new JumpEngine("Alpha");
    public Avgur()
        : base(3, 3) { }

    // TEMP FUNCTION
    public void Temp()
    {
        _impulseEngine.EngineType = 'E';
        _jumpEngine.EngineType = 'A';
    }
}