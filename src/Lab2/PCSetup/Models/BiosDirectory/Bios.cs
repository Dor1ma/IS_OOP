using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.BiosDirectory;

public abstract class Bios
{
    protected Bios(string name, int version, ICollection<Processor> supportableProcessor)
    {
        Name = name;
        Version = version;
        SupportableProcessors = supportableProcessor;
    }

    public string Name { get; private set; }
    public int Version { get; private set; }
    public ICollection<Processor> SupportableProcessors { get; private set; }
    public abstract Bios Clone();

    public Bios ChangeName(string newName)
    {
        Bios clone = Clone();
        clone.Name = newName;
        return clone;
    }

    public Bios ChangeVersion(int newVersion)
    {
        Bios clone = Clone();
        clone.Version = newVersion;
        return clone;
    }

    public Bios ChangeSupportableProcessors(ICollection<Processor> newSupportableProcessors)
    {
        Bios clone = Clone();
        clone.SupportableProcessors = newSupportableProcessors;
        return clone;
    }

    public bool CheckSupportability(Processor processor)
    {
        return SupportableProcessors.Any(localProcessor => localProcessor.Equals(processor));
    }
}