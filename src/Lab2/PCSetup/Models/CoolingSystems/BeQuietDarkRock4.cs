namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.CoolingSystems;

public class BeQuietDarkRock4 : ICooller
{
    private readonly int _height = 163;
    private readonly int _maximumTdp = 200;

    public BeQuietDarkRock4()
    {
        Height = _height;
        MaximumTdp = _maximumTdp;
    }

    public int Height { get; init; }
    public int MaximumTdp { get; init; }
}