using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Models;

public interface IObstacle
{
    public void DoDamage(IDeflector deflector);
}