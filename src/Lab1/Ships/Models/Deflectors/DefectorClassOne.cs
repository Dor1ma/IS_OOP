namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Deflectors;

public class DefectorClassOne : Deflector
{
    private const int DeflectorClassOneHealthPoints = 4;
    public DefectorClassOne(bool isPhoton)
    : base(isPhoton)
    {
        DeflectorHealthPoints = DeflectorClassOneHealthPoints;
    }
}