using System;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class NitrinoParticleNebulae : Environment
{
    private readonly CosmoWhales _cosmoWhale = new CosmoWhales();
    public NitrinoParticleNebulae(int cosmoWhalesCount)
    {
        EngineRequired = "Impulse";
        ExtraRequirenment = "E";
        CosmoWhalesCount = cosmoWhalesCount;
    }

    private int CosmoWhalesCount { get; set; }

    public void Temp()
    {
        Console.WriteLine(_cosmoWhale);
    }
}