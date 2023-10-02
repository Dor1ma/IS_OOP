using Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;
using Environment = Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities.Environment;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Services;

public static class ShipChecker
{
    public static string PermeabilityCheck(Ship ship, Route? route)
    {
        if (route != null)
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
                                if (ship != null)
                                {
                                    segment.FirstObstacle?.DoDamage(ship);
                                    if (ship.IsBroken)
                                    {
                                        return "Ship destroyed";
                                    }
                                }
                            }
                        }

                        if (segment.SecondObstaclesCount != 0)
                        {
                            for (int i = 0; i < segment.SecondObstaclesCount; i++)
                            {
                                if (ship != null)
                                {
                                    segment.SecondObstacle?.DoDamage(ship);
                                    if (ship.IsBroken)
                                    {
                                        return "Ship destroyed";
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        // Exponent acceleration engine required?
                        if (ship != null && ship.ImpulseEngineC.EngineType != 'E')
                        {
                            return "Unsuitable engine";
                        }

                        if (segment.FirstObstaclesCount != 0)
                        {
                            for (int i = 0; i < segment.FirstObstaclesCount; i++)
                            {
                                if (ship != null)
                                {
                                    segment.FirstObstacle?.DoDamage(ship);
                                    if (ship.IsBroken)
                                    {
                                        return "Ship destroyed";
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    // Ship engine type check
                    if (ship != null && ship.EngineTypes != "Both")
                    {
                        return "Unsuitable engine";
                    }

                    // Range check
                    if (ship != null && ship.JumpEngineAlpha.Range < segment.EnvironmentLength)
                    {
                        return "Insufficient engines range";
                    }

                    // Flashes check
                    if (segment.FirstObstaclesCount != 0)
                    {
                        for (int i = 0; i < segment.FirstObstaclesCount; i++)
                        {
                            if (ship != null)
                            {
                                segment.FirstObstacle?.DoDamage(ship);
                                if (!ship.CrewStatus)
                                {
                                    return "Crew is dead";
                                }
                            }
                        }
                    }
                }
            }
        }

        return "OK";
    }

    public static void CostCount(Ship ship, Route route, FuelExchange fuelExchange)
    {
        if (route != null)
        {
            foreach (Environment segment in route.Segments)
            {
                if (segment.EngineRequired == "Impulse")
                {
                    if (segment.ExtraRequirenment != "-")
                    {
                        if (ship != null && ship.ImpulseEngineC.EngineType == 'C')
                        {
                            double accelerationDistance = segment.EnvironmentLength * 0.1 * 0.1;
                            double constSpeed = segment.EnvironmentLength * 0.1;
                            double time = segment.EnvironmentLength / (accelerationDistance + constSpeed);
                            if (fuelExchange != null)
                            {
                                ship.Cost += (time * fuelExchange.ActivePlasmaCost * ship.Mass) +
                                        ship.ImpulseEngineC.StartCost;
                            }
                        }
                        else
                        {
                            double speed = double.Exp(segment.EnvironmentLength);
                            double time = segment.EnvironmentLength / speed;
                            if (fuelExchange != null && ship != null)
                            {
                                ship.Cost += (time * fuelExchange.ActivePlasmaCost * ship.Mass) +
                                        ship.ImpulseEngineC.StartCost;
                            }
                        }
                    }
                    else
                    {
                        double speed = double.Exp(segment.EnvironmentLength);
                        double time = segment.EnvironmentLength / speed;
                        if (fuelExchange != null && ship != null)
                            ship.Cost += (time * fuelExchange.ActivePlasmaCost * ship.Mass) + ship.ImpulseEngineC.StartCost;
                    }
                }
                else
                {
                    if (ship != null && ship.JumpEngineAlpha.EngineType == 'A')
                    {
                        if (fuelExchange != null) ship.Cost += segment.EnvironmentLength * fuelExchange.GravityMatterCost;
                    }
                    else if (ship != null && ship.JumpEngineAlpha.EngineType == 'O')
                    {
                        if (fuelExchange != null)
                        {
                            ship.Cost += segment.EnvironmentLength * double.Log(segment.EnvironmentLength) *
                                    fuelExchange.GravityMatterCost;
                        }
                    }
                    else
                    {
                        if (fuelExchange != null && ship != null)
                            ship.Cost += double.Pow(segment.EnvironmentLength, 2) * fuelExchange.GravityMatterCost;
                    }
                }
            }
        }
    }

    public static Ship ShipsComparator(Ship[]? ships)
    {
        Ship result = new Shuttle(false);
        double localMinimum = double.MaxValue;
        if (ships != null)
        {
            for (int i = 0; i < ships.Length; i++)
            {
                if (ships[i].Cost < localMinimum)
                {
                    localMinimum = ships[i].Cost;
                    result = ships[i];
                }
            }
        }

        return result;
    }
}