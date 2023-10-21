using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Entities.Storage;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Entities.Repositories;

public class Repository
{
    private readonly TestValuesStorage _storage = new TestValuesStorage();

    public void Update(IPcComponentFactory pcComponentFactory)
    {
        _storage.Update(pcComponentFactory.Create());
    }

    public IPcComponent? GetComponent(string componentName)
    {
        return _storage.Find(componentName);
    }
}