namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Deflectors;

public class PhotonPart
{
    public PhotonPart()
    {
        ReflectedFlashes = ShipParameters.PhotonDeflectorLimit;
    }

    public int ReflectedFlashes { get; protected set; }

    public void DefendFromFlash()
    {
        ReflectedFlashes--;
    }
}