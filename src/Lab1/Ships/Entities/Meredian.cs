using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public class Meredian : Ship
{
    private readonly ImpulseEngine _impulseEngine = new ImpulseEngine('E');
    public Meredian()
        : base(2, 2) { }

    // DON'T FORGET TO ADD ANTI-NITRINIUM EMITTER!!!

    // TEMP FUNCTION
    public void Temp()
    {
        _impulseEngine.EngineType = 'E';
    }
}