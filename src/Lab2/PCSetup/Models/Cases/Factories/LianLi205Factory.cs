using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Cases.Instances;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Cases.Factories;

public class LianLi205Factory : ICaseFactory
{
    public ICase Create()
    {
        return new LianLiLanCool205Case();
    }
}