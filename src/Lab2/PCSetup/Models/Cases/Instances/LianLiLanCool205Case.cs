using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Cases.Instances;

public class LianLiLanCool205Case : ICase
{
    private const int CurrentMaximumVideoCardLength = 350;
    private const int CurrentMaximumCoolerHeight = 160;
    private readonly ICollection<string> _supportedFormFactors = new List<string>();

    public LianLiLanCool205Case()
    {
        _supportedFormFactors.Add("ATX");
        _supportedFormFactors.Add("Micro-ATX");
        _supportedFormFactors.Add("Mini-ATX");
    }

    public int MaximumVideoCardLength => CurrentMaximumVideoCardLength;
    public ICollection<string> SupportedFormFactors => _supportedFormFactors;
    public int MaximumCoolerHeight => CurrentMaximumCoolerHeight;
}