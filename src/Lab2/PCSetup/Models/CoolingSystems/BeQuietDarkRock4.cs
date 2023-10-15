using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Vendors.AMD;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Vendors.Intel;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.CoolingSystems;

public class BeQuietDarkRock4 : ICooller
{
    private readonly int _dimensions = 159;
    private readonly ICollection<IProcessor> _supportedSockets = new List<IProcessor>();
    private readonly int _maximumTdp = 200;

    public BeQuietDarkRock4()
    {
        _supportedSockets.Add(new RyzenFive5500());
        _supportedSockets.Add(new IntelIFive12400F());
        Dimensions = _dimensions;
        SupportedSockets = _supportedSockets;
        MaximumTdp = _maximumTdp;
    }

    public int Dimensions { get; init; }
    public ICollection<IProcessor> SupportedSockets { get; init; }
    public int MaximumTdp { get; init; }
}