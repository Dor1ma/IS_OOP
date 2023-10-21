using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.CoolingSystems.Factories;

public class AirCoolerFactory : IPcComponentFactory
{
    private readonly string _name;
    private readonly int _height;
    private readonly int _maximumTdp;
    private readonly ICollection<Processor> _supportableSockets;
    private readonly int _powerConsumption;

    public AirCoolerFactory(
        string name,
        int height,
        int maximumTdp,
        ICollection<Processor> supportableSockets,
        int powerConsumption)
    {
        _name = name;
        _height = height;
        _maximumTdp = maximumTdp;
        _supportableSockets = supportableSockets;
        _powerConsumption = powerConsumption;
    }

    public IPcComponent Create()
    {
        return new Cooler(_name, _height, _maximumTdp, _supportableSockets, _powerConsumption);
    }
}