using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Stella : Ship
{
    private readonly ImpulseEngine _impulseEngine = new ImpulseEngine('C');
    private readonly JumpEngine _jumpEngine = new JumpEngine("Omega");
    public Stella()
        : base(1, 1) { }

    // TEMP FUNCTION
    public void Temp()
    {
        _impulseEngine.EngineType = 'C';
        _jumpEngine.EngineType = 'O';
    }
}