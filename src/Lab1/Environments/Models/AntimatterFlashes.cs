using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Armors;
using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Deflectors;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public class AntimatterFlashes : IObstacle
{
    private const int FlashDamage = 1;
    public int ObstacleDamage { get; init; } = FlashDamage;
    public void DoDamage(Deflector deflector, Armor armor)
    {
        deflector.PhotonPart?.TakeFlashDamage(ObstacleDamage);
    }
}