using System;
using Itmo.ObjectOrientedProgramming.Lab3.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Services;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

public class Display : IDisplay
{
    private IDriver _displayDriver;
    private Message? _message;

    public Display(IDriver displayDriver)
    {
        _displayDriver = displayDriver;
    }

    public void ShowTextByColor(ConsoleColor color)
    {
        if (_message is not null)
        {
            _displayDriver.SaveText(_message.Body);
            _displayDriver.ColorSetup(color);
            _displayDriver.WriteText();
            _displayDriver.Clear();
        }
    }

    public void Save(Message message)
    {
        _message = message;
    }
}