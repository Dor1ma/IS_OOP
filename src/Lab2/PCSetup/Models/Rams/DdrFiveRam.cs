using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.XMPs;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams;

public class DdrFiveRam : IRamType
{
    private readonly string _timings = "36-36-36-96";
    private readonly int _frequency = 5000;
    private readonly double _voltage = 1.35;

    public DdrFiveRam()
    {
        Xmp = new Xmp(_timings, _frequency, _voltage);
    }

    public Xmp Xmp { get; }
    public bool Equals(IRamType ramType)
    {
        return ramType is DdrFiveRam;
    }
}