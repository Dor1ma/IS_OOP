using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Entities;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Models.Commands.FileCommands;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services.Handlers;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services.Handlers.FileHandler;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Services.Handlers.TreeHandler;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab4.Tests;

public class MainTests
{
    [Theory]
    [MemberData(nameof(TestDataGenerator.GetFirstTestData), MemberType = typeof(TestDataGenerator))]
    public void ConnectCommandCheck(string address, string mode, ICommand expected)
    {
        var connectHandler = new ConnectHandler();
        var disconnectHandler = new DisconnectHandler();
        var treeHandler = new TreeHandler();
        var fileHandler = new FileHandler();
        disconnectHandler.SetNext(treeHandler);
        treeHandler.SetNext(fileHandler);
        connectHandler.SetNext(disconnectHandler);
        string stringRequest = "connect " + address + " -m " + mode;
        var request = new ConsoleRequest(stringRequest);

        ICommand? command = connectHandler.Handle(request);
        var concreteCommand = (ConnectCommand?)command;
        string? firstParameter;
        string? secondParameter;
        FieldInfo? fieldInfo = typeof(ConnectCommand).GetField("_newValue", BindingFlags.Instance | BindingFlags.NonPublic);
        if (fieldInfo != null)
        {
            firstParameter = (string?)fieldInfo.GetValue(concreteCommand);
            secondParameter = (string?)fieldInfo.GetValue(expected);
            Assert.Equal(firstParameter, secondParameter);
        }
    }

    [Theory]
    [MemberData(nameof(TestDataGenerator.GetSecondTestData), MemberType = typeof(TestDataGenerator))]
    public void FileMoveCheck(FileMoveCommand expectedCommand)
    {
        var connectHandler = new ConnectHandler();
        var disconnectHandler = new DisconnectHandler();
        var treeHandler = new TreeHandler();
        var fileHandler = new FileHandler();
        disconnectHandler.SetNext(treeHandler);
        treeHandler.SetNext(fileHandler);
        connectHandler.SetNext(disconnectHandler);
        string firstStringRequest = "connect C:\\ -m local";
        string secondStringRequest = "file move Temp/Temp2/test.txt Temp/Temp3";
        var request = new ConsoleRequest(firstStringRequest);
        var secondRequest = new ConsoleRequest(secondStringRequest);

        connectHandler.Handle(request);
        var command = (FileMoveCommand?)connectHandler.Handle(secondRequest);
        string? firstSourceParameter;
        string? firstDist;
        string? secondSourceParameter;
        string? secondDist;
        FieldInfo? fieldOneInfo = typeof(FileMoveCommand).GetField("_sourcePath", BindingFlags.Instance | BindingFlags.NonPublic);
        FieldInfo? fieldSecondInfo = typeof(FileMoveCommand).GetField("_destinationPath", BindingFlags.Instance | BindingFlags.NonPublic);
        if (fieldOneInfo is not null && fieldSecondInfo is not null)
        {
            firstSourceParameter = (string?)fieldOneInfo.GetValue(command);
            firstDist = (string?)fieldSecondInfo.GetValue(command);
            secondSourceParameter = (string?)fieldOneInfo.GetValue(expectedCommand);
            secondDist = (string?)fieldSecondInfo.GetValue(expectedCommand);
            Assert.True(Equals(firstSourceParameter, secondSourceParameter) == Equals(firstDist, secondDist));
        }
    }

    [Theory]
    [MemberData(nameof(TestDataGenerator.GetThirdTestData), MemberType = typeof(TestDataGenerator))]
    public void FileCopyCheck(FileCopyCommand expectedCommand)
    {
        var connectHandler = new ConnectHandler();
        var disconnectHandler = new DisconnectHandler();
        var treeHandler = new TreeHandler();
        var fileHandler = new FileHandler();
        disconnectHandler.SetNext(treeHandler);
        treeHandler.SetNext(fileHandler);
        connectHandler.SetNext(disconnectHandler);
        string firstStringRequest = "connect C:\\ -m local";
        string secondStringRequest = "file copy Temp/Temp2/test.txt Temp/Temp3";
        var request = new ConsoleRequest(firstStringRequest);
        var secondRequest = new ConsoleRequest(secondStringRequest);

        connectHandler.Handle(request);
        var command = (FileCopyCommand?)connectHandler.Handle(secondRequest);
        string? firstSourceParameter;
        string? firstDist;
        string? secondSourceParameter;
        string? secondDist;
        FieldInfo? fieldOneInfo = typeof(FileCopyCommand).GetField("_sourcePath", BindingFlags.Instance | BindingFlags.NonPublic);
        FieldInfo? fieldSecondInfo = typeof(FileCopyCommand).GetField("_destinationPath", BindingFlags.Instance | BindingFlags.NonPublic);
        if (fieldOneInfo is not null && fieldSecondInfo is not null)
        {
            firstSourceParameter = (string?)fieldOneInfo.GetValue(command);
            firstDist = (string?)fieldSecondInfo.GetValue(command);
            secondSourceParameter = (string?)fieldOneInfo.GetValue(expectedCommand);
            secondDist = (string?)fieldSecondInfo.GetValue(expectedCommand);
            Assert.True(Equals(firstSourceParameter, secondSourceParameter) == Equals(firstDist, secondDist));
        }
    }

    private class TestDataGenerator : IEnumerable<object[]>
    {
        private const string Address = "C:\\";
        private const string Mode = "local";
        private const string SourcePath = "Temp/Temp2/test.txt";
        private const string DestinationPath = "Temp/Temp3";

        public static IEnumerable<object[]> GetFirstTestData()
        {
            yield return new object[]
            {
                Address,
                Mode,
                new ConnectCommand(Address, Mode),
            };
        }

        public static IEnumerable<object[]> GetSecondTestData()
        {
            yield return new object[]
            {
                new FileMoveCommand(SourcePath, DestinationPath),
            };
        }

        public static IEnumerable<object[]> GetThirdTestData()
        {
            yield return new object[]
            {
                new FileCopyCommand(SourcePath, DestinationPath),
            };
        }

        public IEnumerator<object[]> GetEnumerator()
        {
            throw new NotValidImplementationException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}