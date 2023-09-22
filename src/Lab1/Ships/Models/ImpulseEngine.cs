namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

public class ImpulseEngine : IEngine
{
    public ImpulseEngine(char engineClass)
    {
        switch (engineClass)
        {
            case 'C':
                EngineType = 'C';
                StartCost = 10;
                break;
            case 'E':
                EngineType = 'E';
                StartCost = 25;
                break;
            case '-':
                EngineType = '-';
                break;
        }
    }

    public char EngineType { get; set; }
    public string FuelType { get; set; } = "ActivePlasma";
    public int StartCost { get; set; }
}