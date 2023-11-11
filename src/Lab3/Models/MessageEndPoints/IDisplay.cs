using System;
using Itmo.ObjectOrientedProgramming.Lab3.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

public interface IDisplay
{
    void ShowTextByColor(ConsoleColor color);
    void Save(Message message);
}