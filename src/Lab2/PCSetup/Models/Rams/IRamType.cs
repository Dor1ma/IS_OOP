using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.XMPs;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams;

public interface IRamType
{
    public Xmp Xmp { get; }
    public bool Equals(IRamType ramType);
}