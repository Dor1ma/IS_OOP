using Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;
using Environment = Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities.Environment;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Services;

public static class ShipChecker
{
    private static IDeflector? _shipDeflector;
    private static IArmor? _shipArmor;
    private static IImpulseEngine? _impulseEngine;
    private static IJumpEngine? _jumpEngine;
    public static string PermeabilityCheck(Ship ship, Route? route)
    {
        if (route != null)
        {
            foreach (Environment segment in route.Segments)
            {
                // Segment with impulse engine required
                if (ship != null)
                {
                    _shipDeflector = ship;
                    _shipArmor = ship;
                }

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
                                    if (_shipDeflector != null && _shipArmor != null)
                                        segment.FirstObstacle?.DoDamage(_shipDeflector, _shipArmor);
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
                                    if (_shipDeflector != null && _shipArmor != null)
                                        segment.SecondObstacle?.DoDamage(_shipDeflector, _shipArmor);
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
                        if (ship != null && _impulseEngine != null)
                        {
                            {
                                _impulseEngine = ship;
                            }

                            if (_impulseEngine.ImpulseEngineType != "E")
                                return "Unsuitable engine";
                        }

                        if (segment.FirstObstaclesCount != 0)
                        {
                            for (int i = 0; i < segment.FirstObstaclesCount; i++)
                            {
                                if (ship != null)
                                {
                                    if (_shipDeflector != null && _shipArmor != null)
                                        segment.FirstObstacle?.DoDamage(_shipDeflector, _shipArmor);
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
                    if (ship != null && _jumpEngine != null)
                    {
                        {
                            _jumpEngine = ship;
                        }

                        if (_jumpEngine.Range < segment.EnvironmentLength)
                            return "Insufficient engines range";
                    }

                    // Flashes check
                    if (segment.FirstObstaclesCount != 0)
                    {
                        for (int i = 0; i < segment.FirstObstaclesCount; i++)
                        {
                            if (ship != null)
                            {
                                if (_shipDeflector != null && _shipArmor != null)
                                    segment.FirstObstacle?.DoDamage(_shipDeflector, _shipArmor);
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
        foreach (Environment segment in route.Segments)
        {
            if (segment.EngineRequired == "Impulse")
            {
                if (segment.ExtraRequirenment != "-")
                {
                    if (ship != null && _impulseEngine != null)
                    {
                        _impulseEngine = ship;
                        if (_impulseEngine.ImpulseEngineType == "C")
                        {
                            double accelerationDistance = segment.EnvironmentLength * 0.1 * 0.1;
                            double constSpeed = segment.EnvironmentLength * 0.1;
                            double time = segment.EnvironmentLength / (accelerationDistance + constSpeed);
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
                if (ship != null && _jumpEngine != null)
                {
                    if (_jumpEngine.JumpEngineType == "Alpha")
                    {
                        if (fuelExchange != null) ship.Cost += segment.EnvironmentLength * fuelExchange.GravityMatterCost;
                    }
                    else if (_jumpEngine.JumpEngineType == "Omega")
                    {
                        if (fuelExchange != null)
                        {
                            ship.Cost += segment.EnvironmentLength * double.Log(segment.EnvironmentLength) *
                                         fuelExchange.GravityMatterCost;
                        }
                    }
                    else
                    {
                        if (fuelExchange != null)
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