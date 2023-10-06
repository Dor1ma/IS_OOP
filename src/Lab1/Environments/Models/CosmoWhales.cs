using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Armors;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Deflectors;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public class CosmoWhales : Obstacle
{
    public override void DoDamage(Deflector deflector, Armor armor)
    {
        if (deflector is DeflectorClassThree)
        {
            deflector.DefendFromWhale();
        }
    }
}