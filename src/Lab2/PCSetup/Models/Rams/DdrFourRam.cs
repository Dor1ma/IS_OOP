using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.XMPs;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams;

public class DdrFourRam : IRamType
{
    private readonly string _timings = "36-36-36-96";
    private readonly int _frequency = 6000;
    private readonly double _voltage = 1.35;
    public DdrFourRam()
    {
        Xmp = new Xmp(_timings, _frequency, _voltage);
    }

    public Xmp Xmp { get; }
}