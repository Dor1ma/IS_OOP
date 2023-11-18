using System;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services.Handlers;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services.Handlers.FileHandler;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services.Handlers.TreeHandler;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Entities;

public class ConsoleApplication : IEntryPoint
{
    public void Start()
    {
        var connectHandler = new ConnectHandler();
        var disconnectHandler = new DisconnectHandler();
        var treeHandler = new TreeHandler();
        var fileHandler = new FileHandler();
        disconnectHandler.SetNext(treeHandler);
        treeHandler.SetNext(fileHandler);
        connectHandler.SetNext(disconnectHandler);
        string address = string.Empty;

        while (true)
        {
            string? stringRequest = Console.ReadLine();
            if (stringRequest is not null)
            {
                var request = new Request(stringRequest);
                ICommand? command = connectHandler.Handle(request);

                if (command is null)
                {
                    Console.WriteLine("Non-existent command");
                }

                if (command is DisconnectCommand)
                {
                    return;
                }

                command?.Execute(ref address);
            }
        }
    }
}