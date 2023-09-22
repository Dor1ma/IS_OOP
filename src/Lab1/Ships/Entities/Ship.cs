using Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Entities;

public abstract class Ship : IArmor, IDeflector
{
    protected Ship(int deflectorClass, int armorClass)
    {
        ImpulseEngine = new ImpulseEngine('-');
        JumpEngine = new JumpEngine("-");
        EngineTypes = "None";
        CrewStatus = true;
        AntiNitriniumEmitter = false;
        switch (deflectorClass)
        {
            case 0:
                IsActive = false;
                break;
            case 1:
                DeflectorClass = 1;
                DestroyedAsteroids = 2;
                DestroyedMeteors = 1;
                ReflectedWhales = 0;
                IsActive = true;
                break;
            case 2:
                DeflectorClass = 2;
                DestroyedAsteroids = 10;
                DestroyedMeteors = 3;
                ReflectedWhales = 0;
                IsActive = true;
                break;
            case 3:
                DeflectorClass = 3;
                DestroyedAsteroids = 40;
                DestroyedMeteors = 10;
                ReflectedWhales = 1;
                IsActive = true;
                break;
        }

        switch (armorClass)
        {
            case 1:
                AsteroidsLimit = 1;
                MeteorsLimit = 0;
                break;
            case 2:
                AsteroidsLimit = 5;
                MeteorsLimit = 2;
                break;
            case 3:
                AsteroidsLimit = 20;
                MeteorsLimit = 5;
                break;
        }
    }

    public ImpulseEngine ImpulseEngine { get; set; }
    public JumpEngine JumpEngine { get; set; }
    public string EngineTypes { get; set; }
    public int AsteroidsLimit { get; set; }
    public int MeteorsLimit { get; set; }
    public bool IsBroken { get; set; }
    public int DeflectorClass { get; set; }
    public int DestroyedAsteroids { get; set; }
    public int DestroyedMeteors { get; set; }
    public int ReflectedWhales { get; set; }
    public int ReflectedFlashes { get; set; }
    public bool IsActive { get; set; }
    public bool IsPhoton { get; set; }
    public bool CrewStatus { get; set; }
    public bool AntiNitriniumEmitter { get; set; }

    public bool[] GetStatus()
    {
        bool[] statusList = { IsActive, IsBroken, CrewStatus };
        return statusList;
    }

    public virtual void Go() { }
}
