using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Factories;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.CoolingSystems;

public class BeQuietDarkRock4 : ICooller
{
    private readonly int _height = 163;
    private readonly ICollection<IProcessor> _supportedSockets;
    private readonly IProcessorFactory _processorFactory = new ProcessorsFactory();
    private readonly int _maximumTdp = 200;

    public BeQuietDarkRock4()
    {
        _supportedSockets = _processorFactory.Create();
        Height = _height;
        SupportedSockets = _supportedSockets;
        MaximumTdp = _maximumTdp;
    }

    public int Height { get; init; }
    public ICollection<IProcessor> SupportedSockets { get; init; }
    public int MaximumTdp { get; init; }
}