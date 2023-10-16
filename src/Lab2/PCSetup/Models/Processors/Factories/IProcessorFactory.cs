using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Factories;

public interface IProcessorFactory
{
    ICollection<IProcessor> Create();
}