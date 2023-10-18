using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Entities.Storage;

public interface IStorage
{
    public void Update(IPcComponent newComponent);
    public IPcComponent? Find(string name);
}