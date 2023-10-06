namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Deflectors;

public abstract class Deflector
{
    protected Deflector(bool isPhoton)
    {
        if (isPhoton)
        {
            PhotonPart = new PhotonPart();
        }
    }

    public PhotonPart? PhotonPart { get; private set; }
    public int DestroyedAsteroids { get; protected set; }
    public int DestroyedMeteors { get; protected set; }

    public void DestroyAsteroid()
    {
        DestroyedAsteroids--;
    }

    public void DestroyMeteor()
    {
        DestroyedMeteors--;
    }

    public virtual void DefendFromWhale()
    { }
}