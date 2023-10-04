using Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;
using Environment = Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities.Environment;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Services;

public class ShipChecker
{
    private readonly IDeflector _shipDeflector;
    private readonly IArmor _shipArmor;
    private readonly IJumpEngine _jumpEngine;
    private readonly Ship _ship;
    private IImpulseEngine _impulseEngine;

    public ShipChecker(Ship ship)
    {
        _shipDeflector = ship;
        _shipArmor = ship;
        _impulseEngine = ship;
        _jumpEngine = ship;
        _ship = ship;
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

    public string PermeabilityCheck(Route? route)
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
                                if (_ship != null)
                                {
                                    if (_shipDeflector != null && _shipArmor != null)
                                        segment.FirstObstacle?.DoDamage(_shipDeflector, _shipArmor);
                                    if (_ship.IsBroken)
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
                                if (_ship != null)
                                {
                                    if (_shipDeflector != null && _shipArmor != null)
                                        segment.SecondObstacle?.DoDamage(_shipDeflector, _shipArmor);
                                    if (_ship.IsBroken)
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
                        if (_ship != null && _impulseEngine != null)
                        {
                            {
                                _impulseEngine = _ship;
                            }

                            if (_impulseEngine.ImpulseEngineType != "E")
                                return "Unsuitable engine";
                        }

                        if (segment.FirstObstaclesCount != 0)
                        {
                            for (int i = 0; i < segment.FirstObstaclesCount; i++)
                            {
                                if (_ship != null)
                                {
                                    if (_shipDeflector != null && _shipArmor != null)
                                        segment.FirstObstacle?.DoDamage(_shipDeflector, _shipArmor);
                                    if (_ship.IsBroken)
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
                    if (_ship != null && _ship.EngineTypes != "Both")
                    {
                        return "Unsuitable engine";
                    }

                    // Range check
                    if (_ship != null && _jumpEngine != null)
                    {
                        if (_jumpEngine.Range < segment.EnvironmentLength)
                            return "Insufficient engines range";
                    }

                    // Flashes check
                    if (segment.FirstObstaclesCount != 0)
                    {
                        for (int i = 0; i < segment.FirstObstaclesCount; i++)
                        {
                            if (_ship != null && _shipDeflector != null)
                            {
                                if (!_shipDeflector.IsActive || !_shipDeflector.IsPhoton)
                                    return "Crew is dead";
                                if (_shipArmor != null)
                                    segment.FirstObstacle?.DoDamage(_shipDeflector, _shipArmor);
                            }
                        }
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
                    if (ship != null && _impulseEngine != null)
                    {
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
}