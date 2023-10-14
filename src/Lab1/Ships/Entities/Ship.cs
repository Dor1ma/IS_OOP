using Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Armors;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Deflectors;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Engines;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public abstract class Ship
{
    public Deflector? Deflector { get; protected init; }
    public Armor? Armor { get; protected init; }
    public AntiNitriniumEmitter? AntiNitriniumEmitter { get; protected init; }
    public ImpulseEngine? ImpulseEngine { get; protected init; }
    public JumpEngine? JumpEngine { get; protected init; }
    public double Mass { get; protected init; }
    public double Cost { get; private set; }

    public bool IsBroken()
    {
        return Armor != null && (Armor.ArmorHealthPoints <= 0);
    }

    public bool CrewStatus()
    {
        if (Deflector?.PhotonPart == null) return false;
        return Deflector.PhotonPart.PhotonPartHealthPoints > 0;
    }

    public void UpdateCost(double computedPrice)
    {
        Cost += computedPrice;
    }

    public void DefenseMode(IObstacle obstacle)
    {
        if (Deflector is not null)
        {
            switch (obstacle)
            {
                case AntimatterFlashes:
                    Deflector.PhotonPart?.TakeFlashDamage(obstacle.ObstacleDamage);
                    break;
                case CosmoWhales:
                {
                    if (AntiNitriniumEmitter is null)
                    {
                        if (Deflector is DeflectorClassThree)
                        {
                            Deflector.TakeDamage(obstacle.ObstacleDamage);
                        }
                        else
                        {
                            Armor?.TakeDamage(obstacle.ObstacleDamage);
                        }
                    }

                    break;
                }

                default:
                    Deflector.TakeDamage(obstacle.ObstacleDamage);
                    break;
            }

            return;
        }

        Armor?.TakeDamage(obstacle.ObstacleDamage);
    }
}
