using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Entities.Storage;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Entities.Repositories;

public class Repository
{
    private readonly TestValuesStorage _storage = new TestValuesStorage();

    public void Update(IPcComponent pcComponent)
    {
        _storage.Update(pcComponent);
    }

    public IPcComponent? GetComponent(string componentName)
    {
        return _storage.Find(componentName);
    }
}