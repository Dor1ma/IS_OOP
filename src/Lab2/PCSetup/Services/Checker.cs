using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Services;

public class Checker
{
    private readonly PersonalComputer _personalComputer;

    public Checker(PersonalComputer personalComputer)
    {
        _personalComputer = personalComputer;
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
            if (_personalComputer.Processor.CoreFrequency < _personalComputer.Ram?.RamType.Xmp.Frequency)
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
            if (_personalComputer.PcCase.FormFactorChecker(_personalComputer.MotherBoard))
            {
                return CheckerMessages.UnsupportableMotherBoardFormFactor;
            }
        }

        return CheckerMessages.Success;
    }
}