using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Armors;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Deflectors;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public class AntimatterFlashes : IObstacle
{
    public void DoDamage(Deflector deflector, Armor armor)
    {
        if (deflector.PhotonPart == null) return;
        deflector.PhotonPart.DefendFromFlash();
    }
}