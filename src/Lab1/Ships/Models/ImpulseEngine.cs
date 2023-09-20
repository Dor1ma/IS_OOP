namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

public class ImpulseEngine : IEngine
{
    public ImpulseEngine(char engineClass)
    {
        switch (engineClass)
        {
            case 'C':
                EngineType = 'C';
                FuelType = "ActivePlasma";
                FuelConsumption = 2; // medium multiplier
                break;
            case 'E':
                EngineType = 'E';
                FuelType = "ActivePlasma";
                FuelConsumption = 5; // high multiplier
                break;
        }
    }

    public char EngineType { get; set; }
    public string FuelType { get; set; } = "ActivePlasma";
    public int FuelConsumption { get; set; }
    public int Speed { get; set; }
}