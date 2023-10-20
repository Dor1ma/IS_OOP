using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.WifiAdapters;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Services.Builder;

public interface IWifiBuilder
{
    IPcBuilder WithWifiAdapter(WifiAdapter wifiAdapter);
}