namespace Itmo.ObjectOrientedProgramming.Lab1.Fuels;

public class GravitonMatter : Fuel
{
    private const int StandardGravitonMatterPrice = 25;
    public GravitonMatter()
    {
        Price = StandardGravitonMatterPrice;
    }
}