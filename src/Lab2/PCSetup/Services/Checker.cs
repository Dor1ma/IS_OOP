using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Services;

public class Checker
{
    private readonly PersonalComputer _personalComputer;
    private int _currentPowerConsumption;

    public Checker(PersonalComputer personalComputer)
    {
        _personalComputer = personalComputer;
    }

    public CheckerMessages Check()
    {
        CheckerMessages result = MotherBoardCheck();
        if (result != CheckerMessages.Success)
        {
            return result;
        }

        result = ProcessorCheck();
        if (result != CheckerMessages.Success)
        {
            return result;
        }

        result = CoolingSystemCheck();
        if (result != CheckerMessages.Success)
        {
            return result;
        }

        result = VideoCardCheck();
        if (result != CheckerMessages.Success)
        {
            return result;
        }

        result = StorageCheck();
        if (result != CheckerMessages.Success)
        {
            return result;
        }

        result = PcCaseCheck();
        if (result != CheckerMessages.Success)
        {
            return result;
        }

        result = PowerSupplyCheck();
        if (result != CheckerMessages.Success)
        {
            return result;
        }

        return result;
    }

    private CheckerMessages MotherBoardCheck()
    {
        if (_personalComputer.MotherBoard is not null && _personalComputer.Processor is not null)
        {
            if (!_personalComputer.Processor.Equals(_personalComputer.MotherBoard.ProcessorSocket))
            {
                return CheckerMessages.UnsupportableSocket;
            }
        }

        if (_personalComputer.MotherBoard?.Bios is not null && _personalComputer.Processor is not null)
        {
            if (!_personalComputer.MotherBoard.Bios.CheckSupportability(_personalComputer.Processor))
            {
                return CheckerMessages.UnsupportableProcessor;
            }

            return CheckerMessages.Success;
        }

        if (_personalComputer.Ram?.RamType is not null)
        {
            if (_personalComputer.MotherBoard != null &&
                !_personalComputer.Ram.RamType.Equals(_personalComputer.MotherBoard.SupportableDdrType))
            {
                return CheckerMessages.UnsupportableDdrType;
            }
        }

        return CheckerMessages.Success;
    }

    private CheckerMessages ProcessorCheck()
    {
        if (_personalComputer.Ram?.RamType.Xmp is not null && _personalComputer.Processor is not null
            && _personalComputer.Ram?.RamType.Xmp.Frequency is not null)
        {
            if (_personalComputer.Processor.MaximumDdrFrequency < _personalComputer.Ram?.RamType.Xmp.Frequency)
            {
                return CheckerMessages.UnsupportableDdrFrequency;
            }
        }

        return CheckerMessages.Success;
    }

    private CheckerMessages CoolingSystemCheck()
    {
        if (_personalComputer.Cooler?.SupportableSockets is not null
                && _personalComputer.MotherBoard?.ProcessorSocket is not null
                && _personalComputer.Processor is not null)
        {
            if (!_personalComputer.Cooler.CheckSupportability(_personalComputer.MotherBoard.ProcessorSocket)
                || !_personalComputer.Cooler.CheckSupportability(_personalComputer.Processor))
            {
                return CheckerMessages.UnsupportableSocket;
            }
        }

        if (_personalComputer.Processor?.Tdp is not null && _personalComputer.Cooler?.MaximumTdp is not null)
        {
            if (_personalComputer.Processor.Tdp > _personalComputer.Cooler.MaximumTdp)
            {
                return CheckerMessages.DisclaimerOfWarrantyLiability;
            }
        }

        return CheckerMessages.Success;
    }

    private CheckerMessages VideoCardCheck()
    {
        if (_personalComputer.Processor?.IntegratedVideoCore is null && _personalComputer.DiscreteGpu is null)
        {
            return CheckerMessages.MissingVideoCard;
        }

        if (_personalComputer.DiscreteGpu?.Length is not null && _personalComputer.PcCase?.MaximumVideoCardLength is not null)
        {
            if (_personalComputer.DiscreteGpu.Length > _personalComputer.PcCase.MaximumVideoCardLength)
            {
                return CheckerMessages.VideoCardDoesNotFitInTheCase;
            }
        }

        return CheckerMessages.Success;
    }

    private CheckerMessages StorageCheck()
    {
        if (_personalComputer.Storage is null)
        {
            return CheckerMessages.MissingStorage;
        }

        return CheckerMessages.Success;
    }

    private CheckerMessages PcCaseCheck()
    {
        if (_personalComputer.PcCase?.SupportedFormFactors is not null
                && _personalComputer.MotherBoard is not null)
        {
            if (!_personalComputer.PcCase.FormFactorChecker(_personalComputer.MotherBoard))
            {
                return CheckerMessages.UnsupportableMotherBoardFormFactor;
            }
        }

        return CheckerMessages.Success;
    }

    private CheckerMessages PowerSupplyCheck()
    {
        if (_personalComputer.Processor?.PowerConsumption is not null && _personalComputer.Cooler?.PowerConsumption is not null
            && _personalComputer.Ram?.PowerConsumption is not null && _personalComputer.DiscreteGpu?.PowerConsumption is not null
            && _personalComputer.Storage?.PowerConsumption is not null && _personalComputer.PowerSupply?.PeakLoad is not null)
        {
            _currentPowerConsumption += _personalComputer.Processor.PowerConsumption;
            _currentPowerConsumption += _personalComputer.Cooler.PowerConsumption;
            _currentPowerConsumption += _personalComputer.Ram.PowerConsumption;
            _currentPowerConsumption += _personalComputer.DiscreteGpu.PowerConsumption;
            _currentPowerConsumption += _personalComputer.Storage.PowerConsumption;
            if (_currentPowerConsumption > _personalComputer.PowerSupply.PeakLoad)
            {
                return CheckerMessages.InsufficientPowerSupplyCapacity;
            }
        }

        return CheckerMessages.Success;
    }
}