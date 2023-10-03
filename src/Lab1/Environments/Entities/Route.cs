using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class Route
{
    public Collection<Environment> Segments { get; } = new(new List<Environment>());

    public void AddSegment(Environment environment)
    {
        Segments.Add(environment);
    }
}