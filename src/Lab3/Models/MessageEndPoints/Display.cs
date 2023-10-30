using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

public class Display : MessageEndPoint
{
    public static void ShowTextByColor(Message message, Color color)
    {
        Console.WriteLine(message.Body, color);
    }
}