using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Cases;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.CoolingSystems;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Motherboards;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.PowerSupplies;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.WifiAdapters;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Services.Builder;

public class PersonalComputerBuilder : IPcBuilder
{
    private static PcCase? _pcCase;
    private static MotherBoard? _motherBoard;
    private static Processor? _processor;
    private static PowerSupply? _powerSupply;
    private static Ram? _ram;
    private static Cooler? _cooler;
    private static DiscreteGpu? _discreteGpu;
    private static Storage? _storage;
    private static WifiAdapter? _wifiAdapter;
    public PersonalComputer Build()
    {
        return new PersonalComputer(
            _pcCase,
            _motherBoard,
            _processor,
            _powerSupply,
            _ram,
            _cooler,
            _discreteGpu,
            _storage,
            _wifiAdapter);
    }

    public IPcBuilder WithPcCase(IPcComponent pcCase)
    {
        _pcCase = (PcCase?)pcCase;
        return this;
    }

    public IPcBuilder WithMotherBoard(IPcComponent motherBoard)
    {
        _motherBoard = (MotherBoard?)motherBoard;
        return this;
    }

    public IPcBuilder WithProcessor(IPcComponent processor)
    {
        _processor = (Processor?)processor;
        return this;
    }

    public IPcBuilder WithPowerSupply(IPcComponent powerSupply)
    {
        _powerSupply = (PowerSupply?)powerSupply;
        return this;
    }

    public IPcBuilder WithRam(IPcComponent ram)
    {
        _ram = (Ram?)ram;
        return this;
    }

    public IPcBuilder WithCoolingSystem(IPcComponent cooler)
    {
        _cooler = (Cooler?)cooler;
        return this;
    }

    public IPcBuilder WithStorage(IPcComponent storage)
    {
        _storage = (Storage?)storage;
        return this;
    }

    public IPcBuilder WithWifiAdapter(IPcComponent wifiAdapter)
    {
        _wifiAdapter = (WifiAdapter?)wifiAdapter;
        return this;
    }

    public IPcBuilder WithVideoCard(IPcComponent discreteGpu)
    {
        _discreteGpu = (DiscreteGpu?)discreteGpu;
        return this;
    }
}