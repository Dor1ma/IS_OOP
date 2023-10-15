namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.CoolingSystems.Factories;

public class DarkRock4Factory : ICollerFactory
{
    public ICooller Create()
    {
        return new BeQuietDarkRock4();
    }
}