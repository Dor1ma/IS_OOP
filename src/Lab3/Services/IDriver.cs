using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Services;

public interface IDriver
{
    void Clear();
    void ColorSetup(ConsoleColor color);
    void SaveText(string text);
    void WriteText();
}