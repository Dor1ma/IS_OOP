using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Services;

public class Validator
{
    private readonly PersonalComputer _personalComputer;
    private int _currentPowerConsumption;

    public Validator(PersonalComputer personalComputer)
    {
        _personalComputer = personalComputer;
    }

    public ValidatorMessages Check()
    {
        ValidatorMessages result = MotherBoardCheck();
        if (result != ValidatorMessages.Success)
        {
            return result;
        }

        result = ProcessorCheck();
        if (result != ValidatorMessages.Success)
        {
            return result;
        }

        result = CoolingSystemCheck();
        if (result != ValidatorMessages.Success)
        {
            return result;
        }

        result = VideoCardCheck();
        if (result != ValidatorMessages.Success)
        {
            return result;
        }

        result = StorageCheck();
        if (result != ValidatorMessages.Success)
        {
            return result;
        }

        result = PcCaseCheck();
        if (result != ValidatorMessages.Success)
        {
            return result;
        }

        result = PowerSupplyCheck();
        if (result != ValidatorMessages.Success)
        {
            return result;
        }

        return result;
    }

    private ValidatorMessages MotherBoardCheck()
    {
        if (_personalComputer.MotherBoard is not null && _personalComputer.Processor is not null)
        {
            if (!_personalComputer.Processor.Equals(_personalComputer.MotherBoard.ProcessorSocket))
            {
                return ValidatorMessages.UnsupportableSocket;
            }
        }

        if (_personalComputer.MotherBoard?.Bios is not null && _personalComputer.Processor is not null)
        {
            if (!_personalComputer.MotherBoard.Bios.CheckSupportability(_personalComputer.Processor))
            {
                return ValidatorMessages.UnsupportableProcessor;
            }

            return ValidatorMessages.Success;
        }

        if (_personalComputer.Ram?.RamType is not null)
        {
            if (_personalComputer.MotherBoard != null &&
                !_personalComputer.Ram.RamType.Equals(_personalComputer.MotherBoard.SupportableDdrType))
            {
                return ValidatorMessages.UnsupportableDdrType;
            }
        }

        return ValidatorMessages.Success;
    }

    private ValidatorMessages ProcessorCheck()
    {
        if (_personalComputer.Ram?.RamType.Xmp is not null && _personalComputer.Processor is not null
            && _personalComputer.Ram?.RamType.Xmp.Frequency is not null)
        {
            if (_personalComputer.Processor.MaximumDdrFrequency < _personalComputer.Ram?.RamType.Xmp.Frequency)
            {
                return ValidatorMessages.UnsupportableDdrFrequency;
            }
        }

        return ValidatorMessages.Success;
    }

    private ValidatorMessages CoolingSystemCheck()
    {
        if (_personalComputer.Cooler?.SupportableSockets is not null
                && _personalComputer.MotherBoard?.ProcessorSocket is not null
                && _personalComputer.Processor is not null)
        {
            if (!_personalComputer.Cooler.CheckSupportability(_personalComputer.MotherBoard.ProcessorSocket)
                || !_personalComputer.Cooler.CheckSupportability(_personalComputer.Processor))
            {
                return ValidatorMessages.UnsupportableSocket;
            }
        }

        if (_personalComputer.Processor?.Tdp is not null && _personalComputer.Cooler?.MaximumTdp is not null)
        {
            if (_personalComputer.Processor.Tdp > _personalComputer.Cooler.MaximumTdp)
            {
                return ValidatorMessages.DisclaimerOfWarrantyLiability;
            }
        }

        return ValidatorMessages.Success;
    }

    private ValidatorMessages VideoCardCheck()
    {
        if (_personalComputer.Processor?.IntegratedVideoCore is null && _personalComputer.DiscreteGpu is null)
        {
            return ValidatorMessages.MissingVideoCard;
        }

        if (_personalComputer.DiscreteGpu?.Length is not null && _personalComputer.PcCase?.MaximumVideoCardLength is not null)
        {
            if (_personalComputer.DiscreteGpu.Length > _personalComputer.PcCase.MaximumVideoCardLength)
            {
                return ValidatorMessages.VideoCardDoesNotFitInTheCase;
            }
        }

        return ValidatorMessages.Success;
    }

    private ValidatorMessages StorageCheck()
    {
        if (_personalComputer.Storage is null)
        {
            return ValidatorMessages.MissingStorage;
        }

        return ValidatorMessages.Success;
    }

    private ValidatorMessages PcCaseCheck()
    {
        if (_personalComputer.PcCase?.SupportedFormFactors is not null
                && _personalComputer.MotherBoard is not null)
        {
            if (!_personalComputer.PcCase.FormFactorChecker(_personalComputer.MotherBoard))
            {
                return ValidatorMessages.UnsupportableMotherBoardFormFactor;
            }
        }

        return ValidatorMessages.Success;
    }

    private ValidatorMessages PowerSupplyCheck()
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
                return ValidatorMessages.InsufficientPowerSupplyCapacity;
            }
        }

        return ValidatorMessages.Success;
    }
}