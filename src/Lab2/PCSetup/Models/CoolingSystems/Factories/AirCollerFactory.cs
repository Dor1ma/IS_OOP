namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.CoolingSystems.Factories;

public class AirCollerFactory : ICollerFactory
{
    public Cooller Create(string name, int height, int maximumTdp)
    {
        return new Cooller(name, height, maximumTdp);
    }
}