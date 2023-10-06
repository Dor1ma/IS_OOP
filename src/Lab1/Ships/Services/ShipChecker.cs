using Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;
using Environment = Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities.Environment;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Services;

public class ShipChecker
{
    public static Ship ShipsComparator(Ship[]? ships)
    {
        if (ships != null)
        {
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

    public void CostCount(Ship ship, Route route, FuelExchange fuelExchange)
    {
        foreach (Environment segment in route.Segments)
        {
            if (segment.EngineRequired == "Impulse")
            {
                if (segment.ExtraRequirenment != "-")
                {
                    if (ship == null || _impulseEngine == null) continue;
                    _impulseEngine = ship;
                    if (_impulseEngine.ImpulseEngineType == "C")
                    {
                        double time = segment.EnvironmentLength / _impulseEngine.Speed;
                        if (fuelExchange != null)
                        {
                            ship.Cost += (time * fuelExchange.ActivePlasmaCost * ship.Mass) + _impulseEngine.StartCost;
                        }
                    }
                    else
                    {
                        double speed = double.Exp(segment.EnvironmentLength);
                        double time = segment.EnvironmentLength / speed;
                        if (fuelExchange != null)
                        {
                            ship.Cost += (time * fuelExchange.ActivePlasmaCost * ship.Mass) +
                                         _impulseEngine.StartCost;
                        }
                    }
                }
                else
                {
                    double speed = double.Exp(segment.EnvironmentLength);
                    double time = segment.EnvironmentLength / speed;
                    if (fuelExchange != null && ship != null && _impulseEngine != null)
                        ship.Cost += (time * fuelExchange.ActivePlasmaCost * ship.Mass) + _impulseEngine.StartCost;
                }
            }
            else
            {
                if (ship == null || _jumpEngine == null) continue;
                switch (_jumpEngine.JumpEngineType)
                {
                    case "Alpha":
                    {
                        if (fuelExchange != null) ship.Cost += segment.EnvironmentLength * fuelExchange.GravityMatterCost;
                        break;
                    }

                    case "Omega":
                    {
                        if (fuelExchange != null)
                        {
                            ship.Cost += segment.EnvironmentLength * double.Log(segment.EnvironmentLength) *
                                         fuelExchange.GravityMatterCost;
                        }

                        break;
                    }

                    default:
                    {
                        if (fuelExchange != null)
                            ship.Cost += double.Pow(segment.EnvironmentLength, 2) * fuelExchange.GravityMatterCost;
                        break;
                    }
                }
            }
        }
    }
}