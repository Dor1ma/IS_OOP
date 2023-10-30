using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models.MessageEndPoints;

public class Messenger : MessageEndPoint
{
    public static void ShowText(Message message)
    {
        Console.WriteLine(message.Body, "MESSENGER");
    }
}