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
    public int DeflectorHealthPoints { get; protected set; }

    public void TakeDamage(int obstacleDamage)
    {
        DeflectorHealthPoints -= obstacleDamage;
    }
}