namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models.Armors;

public abstract class Armor
{
    public int ArmorHealthPoints { get; protected set; }

    public void TakeDamage(int obstacleDamage)
    {
        ArmorHealthPoints -= obstacleDamage;
    }
}