using System;
using System.Collections;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class Route
{
    public ArrayList Segments { get; } = new ArrayList();

    public void CreateRoute(int segmentsCount, int[][] requirements)
    {
        for (int i = 0; i < segmentsCount; i++)
        {
            if (requirements != null)
            {
                int[] requirement = requirements[i];
                int env = requirement[0];
                int segmentLength = requirement[1];
                int asteroids = requirement[2];
                int meteors = requirement[3];
                int flashes = requirement[4];
                int whales = requirement[5];
                Environment newEnvironment;
                switch (env)
                {
                    case 1:
                        newEnvironment = new Space(asteroids, meteors, segmentLength);
                        Segments.Add(newEnvironment);
                        break;
                    case 2:
                        newEnvironment = new HighDensityNebulae(flashes, segmentLength);
                        Segments.Add(newEnvironment);
                        break;
                    case 3:
                        newEnvironment = new NitrinoParticleNebulae(whales, segmentLength);
                        Segments.Add(newEnvironment);
                        break;
                    default:
                        throw new ArgumentException("Unknown environment type");
                }
            }
        }
    }
}