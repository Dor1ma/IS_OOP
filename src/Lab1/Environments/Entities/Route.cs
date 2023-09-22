using System;
using System.Collections;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class Route
{
    public ArrayList Segments { get; } = new ArrayList();

    public void CreateRoute(int segmentsCount)
    {
        for (int i = 0; i < segmentsCount; i++)
        {
            string env = "1";
            Console.Write(env);
            Environment newEnvironment;
            int asteroids = 0;
            int meteors = 0;
            int segmentLength = 0;
            int flashes = 0;
            int whales = 0;
            switch (env)
            {
                case "space":
                    Console.Write(asteroids);
                    Console.Write(meteors);
                    Console.Write(segmentLength);
                    newEnvironment = new Space(asteroids, meteors, segmentLength);
                    Segments.Add(newEnvironment);
                    break;
                case "nebula1":
                    Console.Write(flashes);
                    Console.Write(segmentLength);
                    newEnvironment = new HighDensityNebulae(flashes, segmentLength);
                    Segments.Add(newEnvironment);
                    break;
                case "nebula2":
                    Console.Write(whales);
                    Console.Write(segmentLength);
                    newEnvironment = new NitrinoParticleNebulae(whales, segmentLength);
                    Segments.Add(newEnvironment);
                    break;
                default:
                    throw new ArgumentException("Unknown environment type");
            }
        }
    }
}