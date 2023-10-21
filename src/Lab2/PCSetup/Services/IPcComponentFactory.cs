using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Services;

public interface IPcComponentFactory
{
    IPcComponent Create();
}