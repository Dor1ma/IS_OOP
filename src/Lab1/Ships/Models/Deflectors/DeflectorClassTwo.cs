namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Deflectors;

public class DeflectorClassTwo : Deflector
{
    private const int DeflectorClassTwoHealthPoints = 10;
    public DeflectorClassTwo(bool isPhoton)
        : base(isPhoton)
    {
        DeflectorHealthPoints = DeflectorClassTwoHealthPoints;
    }
}