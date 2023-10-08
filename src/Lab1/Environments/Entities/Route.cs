using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class Route
{
    public ICollection<Environment> Segments { get; } = new List<Environment>();

    public void AddSegment(Environment environment)
    {
        Segments.Add(environment);
    }
}