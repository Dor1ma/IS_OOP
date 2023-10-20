using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Services.Builder;

public interface IPcBuilder
{
    PersonalComputer Build();
    IPcBuilder WithPcCase(IPcComponent pcCase);
    IPcBuilder WithMotherBoard(IPcComponent motherBoard);
    IPcBuilder WithProcessor(IPcComponent processor);
    IPcBuilder WithPowerSupply(IPcComponent powerSupply);
    IPcBuilder WithRam(IPcComponent ram);
    IPcBuilder WithCoolingSystem(IPcComponent cooler);
    IPcBuilder WithStorage(IPcComponent storage);
    IPcBuilder WithWifiAdapter(IPcComponent wifiAdapter);
    IPcBuilder WithVideoCard(IPcComponent discreteGpu);
}