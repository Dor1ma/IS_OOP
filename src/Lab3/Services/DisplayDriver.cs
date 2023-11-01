using System;
using Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services;

public class DisplayDriver : IDriver
{
    private readonly Display _display;
    private ConsoleColor _color = Console.ForegroundColor;

    public DisplayDriver(Display display)
    {
        _display = display;
    }

    public void Clear()
    {
        _display.DeleteMessage();
    }

    public void ColorSetup(ConsoleColor color)
    {
        _color = color;
    }

    public void WriteText()
    {
        _display.ShowTextByColor(_color);
    }
}