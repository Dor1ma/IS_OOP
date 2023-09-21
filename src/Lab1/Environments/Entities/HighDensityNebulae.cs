using System;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class HighDensityNebulae : Environment
{
    private AntimatterFlashes flash = new AntimatterFlashes();
    public HighDensityNebulae(int flashesCount, int length)
    {
        EngineRequired = "Jump";
        ChanelLength = length; // temp value
        EnvironmentLength = ChanelLength;
        FlashesCount = flashesCount;
    }

    private int ChanelLength { get; set; }
    private int FlashesCount { get; set; }

    public void Temp()
    {
        Console.WriteLine(flash);
    }
}