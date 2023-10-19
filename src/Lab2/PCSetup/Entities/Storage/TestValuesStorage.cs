using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Cases;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Chipsets;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Chipsets.AMD;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Chipsets.Intel;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.CoolingSystems;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Motherboards;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.PowerSupplies;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Vendors.AMD;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Vendors.Intel;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Entities.Storage;

public class TestValuesStorage : IStorage
{
    private readonly ICollection<IPcComponent> _components = new List<IPcComponent>();
    private readonly string _firstProcessorName = "Ryzen 5 5600";
    private readonly double _firstProcessorCoreFrequency = 3.5;
    private readonly int _firstProcessorCoreCount = 6;
    private readonly int _firstProcessorMaximumDdrFrequency = 3200;
    private readonly int _firstProcessorTdp = 65;
    private readonly int _firstProcessorPowerConsumption = 65;
    private readonly string _secondProcessorName = "Intel Core I5-12400F";
    private readonly double _secondProcessorCoreFrequency = 2.5;
    private readonly int _secondProcessorCoreCount = 6;
    private readonly int _secondProcessorMaximumDdrFrequency = 4200;
    private readonly int _secondProcessorTdp = 117;
    private readonly int _secondProcessorPowerConsumption = 117;
    private readonly string _amdMotherBoardName = "MSI B450 Gaming Plus Max";
    private readonly int _b450MaximumDdrFrequency = 4133;
    private readonly bool _isXmpSupported = true;
    private readonly int _specialInitValue = 1;
    private readonly IRamType _amdMotherBoardDdrType = new DdrFiveRam();
    private readonly string _intelMotherBoardName = "GIGABYTE B760 DS3H";
    private readonly int _b760MaximumDdrFrequency = 5333;
    private readonly IRamType _intelMotherBoardDdrType = new DdrFiveRam();
    private readonly string _powerSupplyName = "Be quite! Pure Power 11";
    private readonly int _powerSupplyPowerConsumption = 600;
    private readonly string _ssdName = "Kingston A400";
    private readonly int _ssdMemorySize = 240;
    private readonly int _ssdPowerConsumption = 2;
    private readonly int _ssdOperationSpeed = 500;
    private readonly string _ramName = "G.Skill TRIDENT Z5";
    private readonly int _ramMemorySize = 32;
    private readonly int _ramPowerConsumption = 2;
    private readonly IRamType _ramType = new DdrFiveRam();
    private readonly string _gpuName = "MSI GeForce RTX 4060 Gaming X";
    private readonly int _gpuLength = 247;
    private readonly int _gpuWidth = 130;
    private readonly int _gpuVideoMemorySize = 8;
    private readonly double _gpuPciExpressVersion = 4.0;
    private readonly int _gpuChipFrequency = 1830;
    private readonly int _gpuPowerConsumption = 115;
    private readonly string _airCollerName = "Be quite! Pure Rock 2";
    private readonly int _airCollerHeight = 155;
    private readonly int _airCollerMaximumTdp = 150;
    private readonly ICollection<Processor> _aircollerSupportableSockets = new List<Processor>();
    private readonly string _pcCaseName = "LIAN LI Lancool 205 Mesh White";
    private readonly int _pcCaseMaximumVideoCardLength = 350;
    private readonly ICollection<MotherBoard> _pcCaseSupportableFormFactors = new List<MotherBoard>();
    private readonly int _pcCaseMaximumCoolerHeight = 160;

    public TestValuesStorage()
    {
        // Base CPUs initialization
        IntegratedGpu? firstProcessorIntegratedVideoCore = null;
        _components.Add(new Am4Processor(
            _firstProcessorName,
            _firstProcessorCoreFrequency,
            _firstProcessorCoreCount,
            firstProcessorIntegratedVideoCore,
            _firstProcessorMaximumDdrFrequency,
            _firstProcessorTdp,
            _firstProcessorPowerConsumption));
        IntegratedGpu? secondProcessorIntegratedVideoCore = null;
        _components.Add(new Lga1700Processor(
            _secondProcessorName,
            _secondProcessorCoreFrequency,
            _secondProcessorCoreCount,
            secondProcessorIntegratedVideoCore,
            _secondProcessorMaximumDdrFrequency,
            _secondProcessorTdp,
            _secondProcessorPowerConsumption));

        // Base motherboard socket initialization
        string initSocketName = "INIT SOCKET NAME";
        IntegratedGpu? initSocketGpu = null;
        IChipset b450Chipset = new B450Chipset(_b450MaximumDdrFrequency, _isXmpSupported);
        IChipset b760Chipset = new B760Chipset(_b760MaximumDdrFrequency, _isXmpSupported);
        Processor amdMotherBoardSocket = new Am4Processor(
            initSocketName,
            _specialInitValue,
            _specialInitValue,
            initSocketGpu,
            _specialInitValue,
            _specialInitValue,
            _specialInitValue);
        Processor intelMotherBoardSocket = new Lga1700Processor(
            initSocketName,
            _specialInitValue,
            _specialInitValue,
            initSocketGpu,
            _specialInitValue,
            _specialInitValue,
            _specialInitValue);

        // Base motherboards initialization
        _components.Add(new AtxMotherBoard(
            _amdMotherBoardName,
            amdMotherBoardSocket,
            b450Chipset,
            _amdMotherBoardDdrType));
        _components.Add(new AtxMotherBoard(
            _intelMotherBoardName,
            intelMotherBoardSocket,
            b760Chipset,
            _intelMotherBoardDdrType));

        // Base power supply initialization
        _components.Add(new PowerSupply(_powerSupplyName, _powerSupplyPowerConsumption));

        // Base ssd initialization
        _components.Add(new SolidStateDrive(_ssdName, _ssdMemorySize, _ssdPowerConsumption, _ssdOperationSpeed));

        // Base RAM initialization
        _components.Add(new DimmFormFactor(_ramName, _ramMemorySize, _ramPowerConsumption, _ramType));

        // Base Gpu initialization
        _components.Add(new DiscreteGpu(
            _gpuName,
            _gpuLength,
            _gpuWidth,
            _gpuVideoMemorySize,
            _gpuPciExpressVersion,
            _gpuChipFrequency,
            _gpuPowerConsumption));

        // Base cooler initialization
        _aircollerSupportableSockets.Add(new Am4Processor(
            _firstProcessorName,
            _firstProcessorCoreFrequency,
            _firstProcessorCoreCount,
            firstProcessorIntegratedVideoCore,
            _firstProcessorMaximumDdrFrequency,
            _firstProcessorTdp,
            _firstProcessorPowerConsumption));
        _aircollerSupportableSockets.Add(new Lga1700Processor(
            _secondProcessorName,
            _secondProcessorCoreFrequency,
            _secondProcessorCoreCount,
            secondProcessorIntegratedVideoCore,
            _secondProcessorMaximumDdrFrequency,
            _secondProcessorTdp,
            _secondProcessorPowerConsumption));
        _components.Add(new Cooler(_airCollerName, _airCollerHeight, _airCollerMaximumTdp, _aircollerSupportableSockets));

        // Base pc case initialization
        _pcCaseSupportableFormFactors.Add(new AtxMotherBoard(
            _amdMotherBoardName,
            amdMotherBoardSocket,
            b450Chipset,
            _amdMotherBoardDdrType));
        _pcCaseSupportableFormFactors.Add(new MiniAtxBoard(
            _amdMotherBoardName,
            amdMotherBoardSocket,
            b450Chipset,
            _amdMotherBoardDdrType));
        _pcCaseSupportableFormFactors.Add(new MicroAtxBoard(
            _amdMotherBoardName,
            amdMotherBoardSocket,
            b450Chipset,
            _amdMotherBoardDdrType));
        _components.Add(new PcCase(_pcCaseName, _pcCaseMaximumVideoCardLength, _pcCaseSupportableFormFactors, _pcCaseMaximumCoolerHeight));
    }

    public void Update(IPcComponent newComponent)
    {
        _components.Add(newComponent);
    }

    public IPcComponent? Find(string name)
    {
        return _components.FirstOrDefault(component => component.Name == name);
    }
}