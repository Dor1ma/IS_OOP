namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Deflectors;

public class PhotonPart
{
    public int PhotonPartHealthPoints { get; private set; } = 3;

    public void TakeFlashDamage(int flashDamage)
    {
        PhotonPartHealthPoints -= flashDamage;
    }
}