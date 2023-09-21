using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Vaklas : Ship
{
    private readonly ImpulseEngine _impulseEngine = new ImpulseEngine('E');
    private readonly JumpEngine _jumpEngine = new JumpEngine("Gamma");
    public Vaklas()
        : base(1, 2) { }

    public bool Active { get; set; } = true;

    // TEMP FUNCTION
    public void Temp()
    {
        _impulseEngine.Speed = 'c';
        _jumpEngine.EngineType = 'G';
    }
}