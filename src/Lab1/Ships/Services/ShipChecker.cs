using System;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;
using Environment = Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities.Environment;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Services;

public class ShipChecker
{
    private Ship ship;
    private Route route = new Route();

    public ShipChecker(Ship newShip, int segments)
    {
        ship = newShip;
        route.CreateRoute(segments);
    }

    public void Check()
    {
        foreach (Environment segment in route.Segments)
        {
            // Segment with impulse engine required
            if (segment.EngineRequired == "Impulse")
            {
                // Space condition
                if (segment.ExtraRequirenment == "-")
                {
                    if (segment.FirstObstaclesCount != 0)
                    {
                        for (int i = 0; i < segment.FirstObstaclesCount; i++)
                        {
                            segment.FirstObstacle?.DoDamage(ship);
                            if (ship.IsBroken)
                            {
                                Console.WriteLine("Ship is broken"); // TEMP ACTION
                                return;
                            }
                        }
                    }

                    if (segment.SecondObstaclesCount != 0)
                    {
                        for (int i = 0; i < segment.SecondObstaclesCount; i++)
                        {
                            segment.SecondObstacle?.DoDamage(ship);
                            if (ship.IsBroken)
                            {
                                Console.WriteLine("Ship is broken"); // TEMP ACTION
                                return;
                            }
                        }
                    }
                }
                else
                {
                    // Exponent acceleration engine required?
                    if (ship.ImpulseEngine.EngineType != 'E' &&
                        ship.EngineTypes != "Both")
                    {
                        Console.WriteLine("NO!!!");
                    }

                    if (segment.FirstObstaclesCount != 0)
                    {
                        for (int i = 0; i < segment.FirstObstaclesCount; i++)
                        {
                            segment.FirstObstacle?.DoDamage(ship);
                            if (ship.IsBroken)
                            {
                                Console.WriteLine("Ship is broken");
                                return;
                            }
                        }
                    }
                }
            }

            // Segment with jump engine required
            if (segment.EngineRequired == "Jump")
            {
                // Ship engine type check
                if (ship.EngineTypes != "Both")
                {
                    Console.WriteLine("NO!!!");
                }

                // Range check
                if (ship.JumpEngine.Range < segment.EnvironmentLength)
                {
                    Console.WriteLine("NO!!!!!!");
                }

                // Flashes check
                if (segment.FirstObstaclesCount != 0)
                {
                    for (int i = 0; i < segment.FirstObstaclesCount; i++)
                    {
                        segment.FirstObstacle?.DoDamage(ship);
                        if (!ship.CrewStatus)
                        {
                            Console.WriteLine("Crew is dead :("); // Temp action
                        }
                    }
                }
            }
        }
    }
}