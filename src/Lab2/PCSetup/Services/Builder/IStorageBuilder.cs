using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Services.Builder;

public interface IStorageBuilder
{
    IPcBuilder WithStorage(Storage storage);
}