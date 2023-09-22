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

    public void PermeabilityCheck()
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
                    if (ship.ImpulseEngine.EngineType != 'E')
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

    public double CostCount(FuelExchange fuelExchange)
    {
        double cost = 0;
        foreach (Environment segment in route.Segments)
        {
            if (segment.EngineRequired == "Impulse")
            {
                if (segment.ExtraRequirenment != "-")
                {
                    if (ship.ImpulseEngine.EngineType == 'C')
                    {
                        double accelerationDistance = segment.EnvironmentLength * 0.1 * 0.1;
                        double constSpeed = segment.EnvironmentLength * 0.1;
                        double time = segment.EnvironmentLength / (accelerationDistance + constSpeed);
                        if (fuelExchange != null)
                            cost += (time * fuelExchange.ActivePlasmaCost * ship.Mass) + ship.ImpulseEngine.StartCost;
                    }
                    else
                    {
                        double speed = double.Exp(segment.EnvironmentLength);
                        double time = segment.EnvironmentLength / speed;
                        if (fuelExchange != null)
                            cost += (time * fuelExchange.ActivePlasmaCost * ship.Mass) + ship.ImpulseEngine.StartCost;
                    }
                }
                else
                {
                    double speed = double.Exp(segment.EnvironmentLength);
                    double time = segment.EnvironmentLength / speed;
                    if (fuelExchange != null)
                        cost += (time * fuelExchange.ActivePlasmaCost * ship.Mass) + ship.ImpulseEngine.StartCost;
                }
            }
            else
            {
                if (ship.JumpEngine.EngineType == 'A')
                {
                    if (fuelExchange != null) cost += segment.EnvironmentLength * fuelExchange.GravityMatterCost;
                }
                else if (ship.JumpEngine.EngineType == 'O')
                {
                    if (fuelExchange != null)
                    {
                        cost += segment.EnvironmentLength * double.Log(segment.EnvironmentLength) *
                                fuelExchange.GravityMatterCost;
                    }
                }
                else
                {
                    if (fuelExchange != null)
                        cost += double.Pow(segment.EnvironmentLength, 2) * fuelExchange.GravityMatterCost;
                }
            }
        }

        return cost;
    }
}