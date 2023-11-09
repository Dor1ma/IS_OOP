using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services;

public class DisplayDriver : IDriver
{
    private string _output = string.Empty;
    private ConsoleColor _color = Console.ForegroundColor;
    public void Clear()
    {
        _output = string.Empty;
    }

    public void ColorSetup(ConsoleColor color)
    {
        _color = color;
    }

    public void SaveText(string text)
    {
        _output = text;
    }

    public void WriteText()
    {
        Console.WriteLine(_output, _color);
    }
}