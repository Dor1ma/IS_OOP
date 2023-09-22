namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

public class JumpEngine : IEngine
{
    public JumpEngine(string engineClass)
    {
        switch (engineClass)
        {
            case "Alpha":
                EngineType = 'A';
                Range = 100; // temp value
                break;
            case "Omega":
                EngineType = 'O';
                Range = 500; // temp value
                break;
            case "Gamma":
                EngineType = 'G';
                Range = 1000; // temp value
                break;
            case "-":
                EngineType = '-';
                Range = 0;
                break;
        }
    }

    public char EngineType { get; set; }
    public string FuelType { get; set; } = "GravityMatter";
    public int Range { get; set; }
}