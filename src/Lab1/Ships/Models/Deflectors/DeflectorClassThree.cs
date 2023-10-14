namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Deflectors;

public class DeflectorClassThree : Deflector
{
    private const int DeflectorClassThreeHealthPoints = 40;
    public DeflectorClassThree(bool isPhoton)
        : base(isPhoton)
    {
        DeflectorHealthPoints = DeflectorClassThreeHealthPoints;
    }
}