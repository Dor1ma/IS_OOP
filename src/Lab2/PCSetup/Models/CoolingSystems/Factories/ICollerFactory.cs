namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.CoolingSystems.Factories;

public interface ICollerFactory
{
    Cooller Create(string name, int height, int maximumTdp);
}