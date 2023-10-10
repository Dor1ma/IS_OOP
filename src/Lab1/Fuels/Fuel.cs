namespace Itmo.ObjectOrientedProgramming.Lab1.Fuels;

public abstract class Fuel
{
    public int Price { get; protected set; }

    public void UpdatePrice(int newPrice)
    {
        Price = newPrice;
    }
}