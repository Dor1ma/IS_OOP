using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Armors;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Deflectors;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public class Meteor : IAmOnlyForSpace
{
    private const int MeteorDamage = 4;
    public int ObstacleDamage { get; init; } = MeteorDamage;
    public void DoDamage(Deflector deflector, Armor armor)
    {
        if (deflector.DeflectorHealthPoints > 0)
        {
            deflector.TakeDamage(ObstacleDamage);
            return;
        }

        if (armor.ArmorHealthPoints > 0)
        {
            armor.TakeDamage(ObstacleDamage);
        }
    }
}