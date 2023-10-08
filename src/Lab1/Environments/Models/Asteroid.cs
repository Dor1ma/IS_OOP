using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Armors;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Deflectors;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public class Asteroid : IAmOnlyForSpace
{
    private const int AsteroidDamage = 1;
    public int ObstacleDamage { get; init; } = AsteroidDamage;

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