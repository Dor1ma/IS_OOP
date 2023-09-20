namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

public class JumpEngine : IEngine
{
    public JumpEngine(string engineClass)
    {
        switch (engineClass)
        {
            case "Alpha":
                EngineType = 'A';
                FuelConsumption = 2; // Linear multiplier, ex: 2x, where x - fuel price
                Range = 100; // temp value
                break;
            case "Omega":
                EngineType = 'O';
                FuelConsumption = int.Log2(16); // Log multiplier, temp value, need to be changed
                Range = 300; // temp value
                break;
            case "Gamma":
                EngineType = 'G';
                FuelConsumption = 2 * 2; // Square multiplier, temp value, need to be changed
                Range = 1000; // temp value
                break;
        }
    }

    public char EngineType { get; set; }
    public string FuelType { get; set; } = "GravityMatter";
    public int FuelConsumption { get; set; }
    private int Range { get; set; }
}