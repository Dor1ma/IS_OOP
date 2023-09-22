using Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class HighDensityNebulae : Environment
{
    public HighDensityNebulae(int flashesCount, int length)
    {
        FirstObstacle = new AntimatterFlashes();
        EngineRequired = "Jump";
        ChanelLength = length; // temp value
        EnvironmentLength = ChanelLength;
        FirstObstaclesCount = flashesCount;
    }

    private int ChanelLength { get; set; }
}