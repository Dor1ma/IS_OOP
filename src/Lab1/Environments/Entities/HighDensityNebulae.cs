using Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class HighDensityNebulae : Environment
{
    public HighDensityNebulae(int flashesCount, int length)
    {
        EnvironmentLength = length;
        Requirement = typeof(JumpEngine);
        if (flashesCount != 0)
        {
            for (int i = 0; i < flashesCount; i++)
            {
                Obstacles.Add(new AntimatterFlashes());
            }
        }
    }
}