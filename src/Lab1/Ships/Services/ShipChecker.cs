using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;
using Environment = Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities.Environment;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Services;

public static class ShipChecker
{
    public static Ship ShipsComparator(IReadOnlyCollection<Ship> ships)
    {
        Ship result = ships.First();
        double localMinimum = double.MaxValue;
        foreach (Ship ship in ships)
        {
            if (!(ship.Cost < localMinimum)) continue;
            localMinimum = ship.Cost;
            result = ship;
        }

        return result;
    }

    public static CheckerMessages PermeabilityCheck(Ship ship, Route? route)
    {
        if (route is null) return CheckerMessages.Ok;
        foreach (Environment segment in route.Segments)
        {
            // Segment with impulse engine required
            if (segment.Requirement == typeof(ImpulseEngine) && segment.Requirement != typeof(ImpulseEngineClassE))
            {
                // Space condition
                if (segment.Obstacles.Count == 0) continue;
                foreach (IObstacle obstacle in segment.Obstacles)
                {
                    if (ship is null) continue;
                    obstacle.DoDamage(ship);
                    if (ship.IsBroken())
                    {
                        return CheckerMessages.ShipDestroyed;
                    }
                }
            }
            else if (segment.Requirement == typeof(ImpulseEngineClassE))
            {
                // Exponent acceleration engine required?
                if (segment.Requirement == typeof(ImpulseEngineClassE) && segment.Requirement != ship?.GetType())
                {
                    if (ship?.ImpulseEngine is not null)
                    {
                        ImpulseEngine testedEngine = ship.ImpulseEngine;
                        if (testedEngine is ImpulseEngineClassE)
                        {
                            return CheckerMessages.UnsuitableEngine;
                        }

                        if (testedEngine.GetType() != typeof(ImpulseEngineClassE))
                        {
                            return CheckerMessages.UnsuitableEngine;
                        }
                    }
                }

                if (segment.Obstacles.Count == 0) continue;
                foreach (IObstacle obstacle in segment.Obstacles)
                {
                    if (ship is null) continue;
                    obstacle.DoDamage(ship);
                    if (ship.IsBroken())
                    {
                        return CheckerMessages.ShipDestroyed;
                    }
                }
            }
            else
            {
                // Ship engine type check
                if (ship?.JumpEngine is null)
                {
                    return CheckerMessages.UnsuitableEngine;
                }

                // Range check
                if (ship.JumpEngine.Range < segment.EnvironmentLength)
                        return CheckerMessages.InsufficientEnginesRange;

                // Flashes check
                if (segment.Obstacles.Count == 0) continue;
                foreach (IObstacle obstacle in segment.Obstacles)
                {
                    if (ship is null) continue;
                    obstacle.DoDamage(ship);
                    if (!ship.CrewStatus())
                    {
                        return CheckerMessages.CrewIsDead;
                    }
                }
            }
        }

        return CheckerMessages.Ok;
    }

    public static void CostCount(Ship ship, Route route, FuelExchange fuelExchange)
    {
        foreach (Environment segment in route.Segments)
        {
            if (segment.Requirement == typeof(ImpulseEngine))
            {
                if (segment.Requirement != typeof(ImpulseEngineClassE))
                {
                    if (ship?.ImpulseEngine is null) continue;
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
                        if (fuelExchange is null) continue;
                        double result = (time * fuelExchange.ActivePlasmaCost * ship.Mass) +
                                        ship.ImpulseEngine.StartCost;
                        ship.UpdateCost(result);
                    }
                }
                else
                {
                    double speed = double.Exp(segment.EnvironmentLength);
                    double time = segment.EnvironmentLength / speed;
                    if (fuelExchange is null || ship is null) continue;
                    if (ship.ImpulseEngine is null) continue;
                    double result = (time * fuelExchange.ActivePlasmaCost * ship.Mass) +
                                    ship.ImpulseEngine.StartCost;
                    ship.UpdateCost(result);
                }
            }
            else
            {
                if (ship?.JumpEngine is null) continue;
                if (ship.JumpEngine.GetType() == typeof(JumpEngineTypeAlpha))
                {
                    if (fuelExchange is not null)
                    {
                        double result = segment.EnvironmentLength * fuelExchange.GravityMatterCost;
                        ship.UpdateCost(result);
                    }

                    continue;
                }

                if (ship.JumpEngine.GetType() == typeof(JumpEngineTypeOmega))
                {
                    if (fuelExchange is not null)
                    {
                        double result = segment.EnvironmentLength * double.Log(segment.EnvironmentLength) *
                                        fuelExchange.GravityMatterCost;
                        ship.UpdateCost(result);
                    }

                    continue;
                }

                if (ship.JumpEngine.GetType() != typeof(JumpEngineTypeGamma)) continue;
                if (fuelExchange is null) continue;
                {
                    double result = double.Pow(segment.EnvironmentLength, 2) * fuelExchange.GravityMatterCost;
                    ship.UpdateCost(result);
                }
            }
        }
    }
}