namespace Itmo.ObjectOrientedProgramming.Lab1.Ships.Models;

public interface IAntiWhaleDeflector : IDeflector
{
    int ReflectedWhales { get; set; }
}