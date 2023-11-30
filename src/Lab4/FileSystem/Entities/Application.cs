namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystem.Entities;

public static class Application
{
    private static readonly ConsoleApplication ConsoleApplication = new ConsoleApplication();

    public static void Main()
    {
        ConsoleApplication.Start();
    }
}