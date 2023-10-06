using Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;
using Environment = Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities.Environment;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Services;

public static class ShipChecker
{
    public static Ship ShipsComparator(Ship[]? ships)
    {
        if (ships == null) return new Avgur(false);
        Ship result = ships[0];
        double localMinimum = double.MaxValue;
        foreach (Ship ship in ships)
        {
            if (!(ship.Cost < localMinimum)) continue;
            localMinimum = ship.Cost;
            result = ship;
        }

        return result;
    }

    public static string PermeabilityCheck(Ship? ship, Route? route)
    {
        if (route == null) return "OK";
        foreach (Environment segment in route.Segments)
        {
            // Segment with impulse engine required
            if (segment.Requirement == typeof(ImpulseEngine) && segment.Requirement != typeof(ImpulseEngineClassE))
            {
                // Space condition
                if (segment.Obstacles.Count == 0) continue;
                foreach (Obstacle obstacle in segment.Obstacles)
                {
                    if (ship?.Deflector == null) continue;
                    if (ship.Armor == null) continue;
                    obstacle.DoDamage(ship.Deflector, ship.Armor);
                    if (ship.IsBroken())
                    {
                        return "Ship destroyed";
                    }
                }
            }
            else if (segment.Requirement == typeof(ImpulseEngineClassE))
            {
                // Exponent acceleration engine required?
                if (segment.Requirement == typeof(ImpulseEngineClassE) && segment.Requirement != ship?.GetType())
                {
                    if (ship?.ImpulseEngine != null)
                    {
                        ImpulseEngine testedEngine = ship.ImpulseEngine;
                        if (testedEngine.GetType() != typeof(ImpulseEngineClassE))
                        {
                            return "Unsuitable engine";
                        }
                    }
                }

                if (segment.Obstacles.Count == 0) continue;
                foreach (Obstacle obstacle in segment.Obstacles)
                {
                    if (ship?.Deflector == null) continue;
                    if (ship.Armor == null) continue;
                    obstacle.DoDamage(ship.Deflector, ship.Armor);
                    if (ship.IsBroken())
                    {
                        return "Ship destroyed";
                    }
                }
            }
            else
            {
                // Ship engine type check
                if (ship is { JumpEngine: null })
                {
                    return "Unsuitable engine";
                }

                // Range check
                if (ship is { JumpEngine: not null })
                {
                    if (ship.JumpEngine.Range < segment.EnvironmentLength)
                        return "Insufficient engines range";
                }

                // Flashes check
                if (segment.Obstacles.Count == 0) continue;
                foreach (Obstacle obstacle in segment.Obstacles)
                {
                    if (ship?.Deflector == null) continue;
                    if (ship.Armor == null) continue;
                    obstacle.DoDamage(ship.Deflector, ship.Armor);
                    if (!ship.CrewStatus())
                    {
                        return "Crew is dead";
                    }
                }
            }
        }

        return "OK";
    }

    public static void CostCount(Ship ship, Route route, FuelExchange fuelExchange)
    {
        foreach (Environment segment in route.Segments)
        {
            if (segment.Requirement == typeof(ImpulseEngine))
            {
                if (segment.Requirement != typeof(ImpulseEngineClassE))
                {
                    if (ship?.ImpulseEngine == null) continue;
                    if (ship.ImpulseEngine.GetType() == typeof(ImpulseEngineClassC))
                    {
                        double time = segment.EnvironmentLength / ship.ImpulseEngine.Speed;
                        if (fuelExchange == null) continue;
                        double result = (time * fuelExchange.ActivePlasmaCost * ship.Mass) +
                                        ship.ImpulseEngine.StartCost;
                        ship.UpdateCost(result);
                    }
                    else
                    {
                        double speed = double.Exp(segment.EnvironmentLength);
                        double time = segment.EnvironmentLength / speed;
                        if (fuelExchange == null) continue;
                        double result = (time * fuelExchange.ActivePlasmaCost * ship.Mass) +
                                        ship.ImpulseEngine.StartCost;
                        ship.UpdateCost(result);
                    }
                }
                else
                {
                    double speed = double.Exp(segment.EnvironmentLength);
                    double time = segment.EnvironmentLength / speed;
                    if (fuelExchange == null || ship == null) continue;
                    if (ship.ImpulseEngine == null) continue;
                    double result = (time * fuelExchange.ActivePlasmaCost * ship.Mass) +
                                    ship.ImpulseEngine.StartCost;
                    ship.UpdateCost(result);
                }
            }
            else
            {
                if (ship?.JumpEngine == null) continue;
                if (ship.JumpEngine.GetType() == typeof(JumpEngineTypeAlpha))
                {
                    if (fuelExchange != null)
                    {
                        double result = segment.EnvironmentLength * fuelExchange.GravityMatterCost;
                        ship.UpdateCost(result);
                    }

                    continue;
                }

                if (ship.JumpEngine.GetType() == typeof(JumpEngineTypeOmega))
                {
                    if (fuelExchange != null)
                    {
                        double result = segment.EnvironmentLength * double.Log(segment.EnvironmentLength) *
                                        fuelExchange.GravityMatterCost;
                        ship.UpdateCost(result);
                    }

                    continue;
                }

                if (ship.JumpEngine.GetType() != typeof(JumpEngineTypeGamma)) continue;
                if (fuelExchange != null)
                {
                    double result = double.Pow(segment.EnvironmentLength, 2) * fuelExchange.GravityMatterCost;
                    ship.UpdateCost(result);
                }
            }
        }
    }
}