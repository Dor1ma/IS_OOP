namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class HighDensityNebulae : Environment
{
    public HighDensityNebulae()
    {
        EngineRequired = "Jump";
        ChanelLength = 300; // temp value
    }

    private int ChanelLength { get; set; }
}