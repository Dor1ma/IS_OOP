using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Vendors.AMD;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Vendors.Intel;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Factories;

public class ProcessorsFactory : IProcessorFactory
{
    private const string FirstCpuName = "Ryzen 5 5500";
    private const double FirstCpuCoreFrequency = 3.6;
    private const int FirstCpuCoreCount = 6;
    private const IIntegratedGpu? FirstCpuIntegratedVideoCore = null;
    private const int FirstCpuCMaximumDdrFrequency = 3200;
    private const int FirstCpuTdp = 65;
    private const int FirstCpuPowerConsumption = 88;
    private const string SecondCpuName = "Intel Core I5-12400F";
    private const double SecondCpuCoreFrequency = 2.5;
    private const int SecondCpuCoreCount = 6;
    private const IIntegratedGpu? SecondCpuIntegratedVideoCore = null;
    private const int SecondCpuCMaximumDdrFrequency = 4800;
    private const int SecondCpuTdp = 117;
    private const int SecondCpuPowerConsumption = 117;

    public ProcessorsFactory()
    {
        Processors.Add(new Am4Processor(
            FirstCpuName,
            FirstCpuCoreFrequency,
            FirstCpuCoreCount,
            FirstCpuIntegratedVideoCore,
            FirstCpuCMaximumDdrFrequency,
            FirstCpuTdp,
            FirstCpuPowerConsumption));
        Processors.Add(new Lga1700Processor(
            SecondCpuName,
            SecondCpuCoreFrequency,
            SecondCpuCoreCount,
            SecondCpuIntegratedVideoCore,
            SecondCpuCMaximumDdrFrequency,
            SecondCpuTdp,
            SecondCpuPowerConsumption));
    }

    private ICollection<IProcessor> Processors { get; } = new List<IProcessor>();
    public ICollection<IProcessor> Create()
    {
        return Processors;
    }
}