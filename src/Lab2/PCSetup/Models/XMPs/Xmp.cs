namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.XMPs;

public class Xmp
{
    public Xmp(string timings, int frequency, double voltage)
    {
        Timings = timings;
        Frequency = frequency;
        Voltage = voltage;
    }

    public string Timings { get; }
    public int Frequency { get; }
    public double Voltage { get; }
}